using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Dictionaries.Helpers;
using FreakFightsFan.Shared.Features.Fights.Commands;
using FreakFightsFan.Shared.Features.Fights.Helpers;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Fights.Commands
{
    public static class UpdateFightFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPut("/api/fights/{id}", async (
                int id,
                UpdateFight.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                command.Id = id;
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
                .WithTags("Fights")
                .RequireAuthorization(Policy.Admin);

            return app;
        }

        public class Handler : IRequestHandler<UpdateFight.Command, Unit>
        {
            private readonly IFightRepository _fightRepository;
            private readonly IClock _clock;
            private readonly ITeamService _teamService;
            private readonly IMyDictionaryService _dictionaryService;
            private readonly IMyDictionaryItemRepository _dictionaryItemRepository;

            public Handler(IFightRepository fightRepository, IClock clock, ITeamService teamService,
                IMyDictionaryService dictionaryService, IMyDictionaryItemRepository dictionaryItemRepository)
            {
                _fightRepository = fightRepository;
                _clock = clock;
                _teamService = teamService;
                _dictionaryService = dictionaryService;
                _dictionaryItemRepository = dictionaryItemRepository;
            }

            public async Task<Unit> Handle(UpdateFight.Command command, CancellationToken cancellationToken)
            {
                var fight = await _fightRepository.Get(command.Id) ?? throw new MyNotFoundException();

                await ValidateCommand(command);

                var teamsToAdd = await _teamService.CreateFightTeams(command.Teams);
                var teamsToRemove = fight.Teams.Select(x => x.Id).ToList();

                fight.Modified = _clock.Current();
                fight.VideoUrl = command.VideoUrl;
                fight.Type = (command.TypeId is not null) ? await _dictionaryItemRepository.Get(command.TypeId.Value) : null;
                fight.Teams.AddRange(teamsToAdd);
                fight.Teams.RemoveAll(x => teamsToRemove.Contains(x.Id));

                await _fightRepository.Update(fight);
                return Unit.Value;
            }

            private async Task ValidateCommand(UpdateFight.Command command)
            {
                if (command.TypeId is not null)
                {
                    var isTypeValid = await _dictionaryService.ItemIsFromDictionary(command.TypeId.Value, DictionaryCode.FightType);
                    if (!isTypeValid)
                        throw new MyValidationException($"{nameof(command.TypeId)}", $"Dictionary item should be chosen from dictionary with code: {DictionaryCode.FightType}");
                }
            }
        }
    }
}
