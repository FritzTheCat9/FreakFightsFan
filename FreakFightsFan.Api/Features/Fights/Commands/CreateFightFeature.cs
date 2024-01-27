using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Localization;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Dictionaries.Helpers;
using FreakFightsFan.Shared.Features.Fights.Commands;
using FreakFightsFan.Shared.Features.Fights.Helpers;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Api.Features.Fights.Commands
{
    public static class CreateFightFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/fights", async (
                CreateFight.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                int fightId = await mediator.Send(command, cancellationToken);
                return Results.CreatedAtRoute("GetFight", new { id = fightId });
            })
                .WithTags("Fights")
                .RequireAuthorization(Policy.Admin);

            return app;
        }

        public class Handler : IRequestHandler<CreateFight.Command, int>
        {
            private readonly IFightRepository _fightRepository;
            private readonly IClock _clock;
            private readonly IEventRepository _eventRepository;
            private readonly ITeamService _teamService;
            private readonly IMyDictionaryService _dictionaryService;
            private readonly IMyDictionaryItemRepository _dictionaryItemRepository;
            private readonly IStringLocalizer<ApiValidationMessage> _localizer;

            public Handler(IFightRepository fightRepository, IClock clock, IEventRepository eventRepository, ITeamService teamService, 
                IMyDictionaryService dictionaryService, IMyDictionaryItemRepository dictionaryItemRepository, IStringLocalizer<ApiValidationMessage> localizer)
            {
                _fightRepository = fightRepository;
                _clock = clock;
                _eventRepository = eventRepository;
                _teamService = teamService;
                _dictionaryService = dictionaryService;
                _dictionaryItemRepository = dictionaryItemRepository;
                _localizer = localizer;
            }

            public async Task<int> Handle(CreateFight.Command command, CancellationToken cancellationToken)
            {
                await ValidateCommand(command, _localizer);

                var myEvent = await _eventRepository.Get(command.EventId) ?? throw new MyNotFoundException();
                var teamsInFight = await _teamService.CreateFightTeams(command.Teams);

                var fight = new Fight
                {
                    Id = 0,
                    Created = _clock.Current(),
                    Modified = _clock.Current(),
                    EventId = command.EventId,
                    OrderNumber = myEvent.Fights.Count + 1,
                    VideoUrl = command.VideoUrl,
                    Type = (command.TypeId is not null) ? await _dictionaryItemRepository.Get(command.TypeId.Value) : null,
                };

                fight.Teams.AddRange(teamsInFight);

                return await _fightRepository.Create(fight);
            }

            private async Task ValidateCommand(CreateFight.Command command, IStringLocalizer<ApiValidationMessage> localizer)
            {
                var myEvent = await _eventRepository.Get(command.EventId) ?? throw new MyNotFoundException();

                if (myEvent.Fights.Count >= FightsConsts.MaxFightsInOneEvent)
                    throw new MyValidationException(nameof(CreateFight.Command.EventId), 
                        localizer[nameof(ApiValidationMessageString.EventIdMaxFightsInOneEvent), FightsConsts.MaxFightsInOneEvent]);

                if (command.TypeId is not null)
                {
                    var isTypeValid = await _dictionaryService.ItemIsFromDictionary(command.TypeId.Value, DictionaryCode.FightType);
                    if (!isTypeValid)
                        throw new MyValidationException(nameof(CreateFight.Command.TypeId),
                            localizer[nameof(ApiValidationMessageString.DictionaryItemMustBeInDictionary), DictionaryCode.FightType]);
                }
            }
        }
    }
}
