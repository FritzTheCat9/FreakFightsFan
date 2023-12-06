using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Fights.Extensions;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Fights.Helpers;
using FreakFightsFan.Shared.Features.Fights.Requests;
using MediatR;

namespace FreakFightsFan.Api.Features.Fights.Commands
{
    public static class UpdateFight
    {
        public class Command : IRequest<Unit>
        {
            public int Id { get; set; }
            public List<CreateTeamModel> Teams { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator()
            {

            }
        }

        public class Handler : IRequestHandler<Command, Unit>
        {
            private readonly IFightRepository _fightRepository;
            private readonly IClock _clock;
            private readonly ITeamService _teamService;

            public Handler(IFightRepository fightRepository, IClock clock, ITeamService teamService)
            {
                _fightRepository = fightRepository;
                _clock = clock;
                _teamService = teamService;
            }

            public async Task<Unit> Handle(Command command, CancellationToken cancellationToken)
            {
                var fight = await _fightRepository.Get(command.Id) ?? throw new MyNotFoundException();

                ValidateCommand(command);

                var teamsToAdd = await _teamService.CreateFightTeams(command.Teams);
                var teamsToRemove = fight.Teams.Select(x => x.Id).ToList();

                fight.Modified = _clock.Current();
                fight.Teams.AddRange(teamsToAdd);
                fight.Teams.RemoveAll(x => teamsToRemove.Contains(x.Id));

                await _fightRepository.Update(fight);
                return Unit.Value;
            }

            private void ValidateCommand(Command command)
            {
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

        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPut("/api/fights/{id}", async (
                int id,
                UpdateFightRequest request,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                return Results.Ok(await mediator.Send(request.ToUpdateFightCommand(id), cancellationToken));
            })
                .WithTags("Fights");

            return app;
        }
    }
}
