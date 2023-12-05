using Carter;
using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
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
            private readonly IFighterRepository _fighterRepository;

            public Handler(IFightRepository fightRepository, IClock clock, IEventRepository eventRepository, IFighterRepository fighterRepository)
            {
                _fightRepository = fightRepository;
                _clock = clock;
                _eventRepository = eventRepository;
                _fighterRepository = fighterRepository;
            }

            public async Task<int> Handle(Command command, CancellationToken cancellationToken)
            {
                await ValidateCommand(command);

                var teamsInFight = await CreateTeams(command);

                var fight = new Fight
                {
                    Id = 0,
                    Created = _clock.Current(),
                    Modified = _clock.Current(),
                    EventId = command.EventId,
                };

                fight.Teams.AddRange(teamsInFight);

                return await _fightRepository.Create(fight);
            }

            private async Task<List<Team>> CreateTeams(Command command)
            {
                var teamsInFight = new List<Team>();
                var teamNumber = 0;
                foreach (var createTeamModel in command.Teams)
                {
                    var fightersInTeam = new List<Fighter>();
                    foreach (var fighterId in createTeamModel.FightersIds)
                    {
                        var fighter = await _fighterRepository.Get(fighterId) ?? throw new MyNotFoundException();
                        fightersInTeam.Add(fighter);
                    }

                    var team = new Team
                    {
                        Created = _clock.Current(),
                        Modified = _clock.Current(),
                        Number = teamNumber,
                    };
                    team.Fighters.AddRange(fightersInTeam);

                    teamsInFight.Add(team);
                    teamNumber++;
                }

                return teamsInFight;
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
                    if (createTeamModel.FightersIds.Count < FightsOptions.MinTeamFighters)
                        throw new MyValidationException("Teams", $"At least {FightsOptions.MinTeamFighters} fighter should be added for each team");

                    if (createTeamModel.FightersIds.Count > FightsOptions.MaxTeamFighters)
                        throw new MyValidationException("Teams", $"Each team can contain only {FightsOptions.MaxTeamFighters} fighters");

                    foreach (var fighterId in createTeamModel.FightersIds)
                    {
                        if (!allFightersIds.Contains(fighterId))
                            allFightersIds.Add(fighterId);
                        else
                            throw new MyValidationException("Teams", $"Each fighter can only be selected to the team once");
                    }
                }
            }
        }
    }

    public class CreateFightEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/api/fights", async (
                CreateFightRequest createFightRequest,
                IMediator mediator,
                CancellationToken cancellationToken) =>
                {
                    var command = new CreateFight.Command()
                    {
                        EventId = createFightRequest.EventId,
                        Teams = createFightRequest.Teams, 
                    };

                    int fightId = await mediator.Send(command, cancellationToken);
                    return Results.CreatedAtRoute("GetFight", new { id = fightId });
                })
                .WithTags("Fights");
        }
    }
}
