using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Api.Localization;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Dictionaries.Helpers;
using FreakFightsFan.Shared.Features.Events.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Api.Features.Events.Commands;

public static class UpdateEventFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapPut("/api/events/{id:int}", async (
                int id,
                UpdateEvent.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                command.Id = id;
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
            .WithTags(Tags.Events)
            .RequireAuthorization(Policy.Admin);
    }

    public class Handler(
        IEventRepository eventRepository,
        IClock clock,
        IMyDictionaryItemRepository dictionaryItemRepository,
        IMyDictionaryService dictionaryService,
        IStringLocalizer<ApiValidationMessage> localizer)
        : IRequestHandler<UpdateEvent.Command, Unit>
    {
        public async Task<Unit> Handle(UpdateEvent.Command command, CancellationToken cancellationToken)
        {
            var myEvent = await eventRepository.Get(command.Id) ?? throw new MyNotFoundException();

            await ValidateCommand(command, localizer);

            myEvent.Modified = clock.Current();
            myEvent.Name = command.Name;
            myEvent.Date = command.Date.GetValueOrDefault(clock.Current());
            myEvent.City = command.CityId is not null
                ? await dictionaryItemRepository.Get(command.CityId.Value)
                : null;
            myEvent.Hall = command.HallId is not null
                ? await dictionaryItemRepository.Get(command.HallId.Value)
                : null;

            await eventRepository.Update(myEvent);
            return Unit.Value;
        }

        private async Task ValidateCommand(
            UpdateEvent.Command command,
            IStringLocalizer<ApiValidationMessage> localizer)
        {
            if (command.CityId is not null)
            {
                var isCityValid =
                    await dictionaryService.ItemIsFromDictionary(command.CityId.Value, DictionaryCode.City);
                if (!isCityValid)
                {
                    throw new MyValidationException(nameof(UpdateEvent.Command.CityId),
                        localizer[nameof(ApiValidationMessageString.DictionaryItemMustBeInDictionary),
                            DictionaryCode.City]);
                }
            }

            if (command.HallId is not null)
            {
                var isHallValid =
                    await dictionaryService.ItemIsFromDictionary(command.HallId.Value, DictionaryCode.Hall);
                if (!isHallValid)
                {
                    throw new MyValidationException(nameof(UpdateEvent.Command.HallId),
                        localizer[nameof(ApiValidationMessageString.DictionaryItemMustBeInDictionary),
                            DictionaryCode.Hall]);
                }
            }
        }
    }
}