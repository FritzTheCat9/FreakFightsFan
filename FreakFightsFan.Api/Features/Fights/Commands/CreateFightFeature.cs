using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Api.Localization;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Dictionaries.Helpers;
using FreakFightsFan.Shared.Features.Fights.Commands;
using FreakFightsFan.Shared.Features.Fights.Helpers;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Api.Features.Fights.Commands;

public static class CreateFightFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapPost("/api/fights", async (
                CreateFight.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var fightId = await mediator.Send(command, cancellationToken);
                return Results.CreatedAtRoute("GetFight", new { id = fightId });
            })
            .WithTags(Tags.Fights)
            .RequireAuthorization(Policy.Admin);
    }

    public class Handler(
        IFightRepository fightRepository,
        IClock clock,
        IEventRepository eventRepository,
        ITeamService teamService,
        IMyDictionaryService dictionaryService,
        IMyDictionaryItemRepository dictionaryItemRepository,
        IStringLocalizer<ApiValidationMessage> localizer)
        : IRequestHandler<CreateFight.Command, int>
    {
        public async Task<int> Handle(CreateFight.Command command, CancellationToken cancellationToken)
        {
            await ValidateCommand(command, localizer);

            var myEvent = await eventRepository.Get(command.EventId) ?? throw new MyNotFoundException();
            var teamsInFight = await teamService.CreateFightTeams(command.Teams);

            var fight = new Fight
            {
                Id = 0,
                Created = clock.Current(),
                Modified = clock.Current(),
                EventId = command.EventId,
                OrderNumber = myEvent.Fights.Count + 1,
                VideoUrl = command.VideoUrl,
                Type = command.TypeId is not null
                    ? await dictionaryItemRepository.Get(command.TypeId.Value)
                    : null
            };

            fight.Teams.AddRange(teamsInFight);

            return await fightRepository.Create(fight);
        }

        private async Task ValidateCommand(
            CreateFight.Command command,
            IStringLocalizer<ApiValidationMessage> localizer)
        {
            var myEvent = await eventRepository.Get(command.EventId) ?? throw new MyNotFoundException();

            if (myEvent.Fights.Count >= FightsConsts.MaxFightsInOneEvent)
            {
                throw new MyValidationException(nameof(CreateFight.Command.EventId),
                    localizer[nameof(ApiValidationMessageString.EventIdMaxFightsInOneEvent),
                        FightsConsts.MaxFightsInOneEvent]);
            }

            if (command.TypeId is not null)
            {
                var isTypeValid =
                    await dictionaryService.ItemIsFromDictionary(command.TypeId.Value, DictionaryCode.FightType);
                if (!isTypeValid)
                {
                    throw new MyValidationException(nameof(CreateFight.Command.TypeId),
                        localizer[nameof(ApiValidationMessageString.DictionaryItemMustBeInDictionary),
                            DictionaryCode.FightType]);
                }
            }
        }
    }
}