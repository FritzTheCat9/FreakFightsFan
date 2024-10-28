using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Api.Localization;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Dictionaries.Helpers;
using FreakFightsFan.Shared.Features.Fights.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Api.Features.Fights.Commands;

public static class UpdateFightFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapPut("/api/fights/{id:int}", async (
                int id,
                UpdateFight.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                command.Id = id;
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
            .WithTags(Tags.Fights)
            .RequireAuthorization(Policy.Admin);
    }

    public class Handler(
        IFightRepository fightRepository,
        IClock clock,
        ITeamService teamService,
        IMyDictionaryService dictionaryService,
        IMyDictionaryItemRepository dictionaryItemRepository,
        IStringLocalizer<ApiValidationMessage> localizer)
        : IRequestHandler<UpdateFight.Command, Unit>
    {
        public async Task<Unit> Handle(
            UpdateFight.Command command,
            CancellationToken cancellationToken)
        {
            var fight = await fightRepository.Get(command.Id) ?? throw new MyNotFoundException();

            await ValidateCommand(command, localizer);

            var teamsToAdd = await teamService.CreateFightTeams(command.Teams);
            var teamsToRemove = fight.Teams.Select(x => x.Id).ToList();

            fight.Modified = clock.Current();
            fight.VideoUrl = command.VideoUrl;
            fight.Type = command.TypeId is not null
                ? await dictionaryItemRepository.Get(command.TypeId.Value)
                : null;
            fight.Teams.AddRange(teamsToAdd);
            fight.Teams.RemoveAll(x => teamsToRemove.Contains(x.Id));

            await fightRepository.Update(fight);
            return Unit.Value;
        }

        private async Task ValidateCommand(
            UpdateFight.Command command,
            IStringLocalizer<ApiValidationMessage> localizer)
        {
            if (command.TypeId is not null)
            {
                var isTypeValid =
                    await dictionaryService.ItemIsFromDictionary(command.TypeId.Value, DictionaryCode.FightType);
                if (!isTypeValid)
                {
                    throw new MyValidationException(nameof(UpdateFight.Command.TypeId),
                        localizer[nameof(ApiValidationMessageString.DictionaryItemMustBeInDictionary),
                            DictionaryCode.FightType]);
                }
            }
        }
    }
}