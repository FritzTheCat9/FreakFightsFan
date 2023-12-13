using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Fights.Extensions;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Fights.Helpers;
using FreakFightsFan.Shared.Features.Fights.Requests;
using MediatR;

namespace FreakFightsFan.Api.Features.Fights.Commands
{
    public static class CreateFight
    {
        public class Command : IRequest<int>
        {
            public int EventId { get; set; }
            public List<CreateTeamModel> Teams { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator()
            {

            }
        }

        public class Handler : IRequestHandler<Command, int>
        {
            private readonly IFightRepository _fightRepository;
            private readonly IClock _clock;
            private readonly IEventRepository _eventRepository;
            private readonly ITeamService _teamService;

            public Handler(IFightRepository fightRepository, IClock clock, IEventRepository eventRepository, ITeamService teamService)
            {
                _fightRepository = fightRepository;
                _clock = clock;
                _eventRepository = eventRepository;
                _teamService = teamService;
            }

            public async Task<int> Handle(Command command, CancellationToken cancellationToken)
            {
                await ValidateCommand(command);

                var myEvent = await _eventRepository.Get(command.EventId) ?? throw new MyNotFoundException();
                var teamsInFight = await _teamService.CreateFightTeams(command.Teams);

                var fight = new Fight
                {
                    Id = 0,
                    Created = _clock.Current(),
                    Modified = _clock.Current(),
                    EventId = command.EventId, 
                    OrderNumber = myEvent.Fights.Count + 1,
                };

                fight.Teams.AddRange(teamsInFight);

                return await _fightRepository.Create(fight);
            }

            private async Task ValidateCommand(Command command)
            {
                var myEvent = await _eventRepository.Get(command.EventId) ?? throw new MyNotFoundException();

                if (myEvent.Fights.Count >= FightsOptions.MaxFightsInOneEvent)
                    throw new MyValidationException("EventId", $"You cannot add more than {FightsOptions.MaxFightsInOneEvent} fights in one event");

                if (command.Teams.Count < FightsOptions.MinTeamsNumber)
                    throw new MyValidationException("Teams", $"At least {FightsOptions.MinTeamsNumber} teams should be added for each fight");

                if (command.Teams.Count > FightsOptions.MaxTeamsNumber)
                    throw new MyValidationException("Teams", $"Each fight can contain only {FightsOptions.MaxTeamsNumber} teams");

                var allFightersIds = new List<int>();
                foreach (var createTeamModel in command.Teams)
                {
                    if (createTeamModel.Fighters.Count < FightsOptions.MinTeamFighters)
                        throw new MyValidationException("Teams", $"At least {FightsOptions.MinTeamFighters} fighter should be added for each team");

                    if (createTeamModel.Fighters.Count > FightsOptions.MaxTeamFighters)
                        throw new MyValidationException("Teams", $"Each team can contain only {FightsOptions.MaxTeamFighters} fighters");

                    foreach (var fighter in createTeamModel.Fighters)
                    {
                        if (!allFightersIds.Contains(fighter.FighterId))
                            allFightersIds.Add(fighter.FighterId);
                        else
                            throw new MyValidationException("Teams", $"Each fighter can only be selected to the team once");
                    }
                }
            }
        }

        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/fights", async (
                CreateFightRequest request,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                int fightId = await mediator.Send(request.ToCreateFightCommand(), cancellationToken);
                return Results.CreatedAtRoute("GetFight", new { id = fightId });
            })
                .WithTags("Fights");

            return app;
        }
    }
}
