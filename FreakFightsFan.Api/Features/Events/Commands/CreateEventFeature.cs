using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
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

public static class CreateEventFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapPost("/api/events", async (
                CreateEvent.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var eventId = await mediator.Send(command, cancellationToken);
                return Results.CreatedAtRoute("GetEvent", new { id = eventId });
            })
            .WithTags(Tags.Events)
            .RequireAuthorization(Policy.Admin);
    }

    public class Handler(
        IEventRepository eventRepository,
        IFederationRepository federationRepository,
        IClock clock,
        IMyDictionaryItemRepository dictionaryItemRepository,
        IMyDictionaryService dictionaryService,
        IStringLocalizer<ApiValidationMessage> localizer)
        : IRequestHandler<CreateEvent.Command, int>
    {
        public async Task<int> Handle(
            CreateEvent.Command command,
            CancellationToken cancellationToken)
        {
            await ValidateCommand(command, localizer);

            var myEvent = new Event
            {
                Id = 0,
                Created = clock.Current(),
                Modified = clock.Current(),
                Name = command.Name,
                Date = command.Date.GetValueOrDefault(clock.Current()),
                FederationId = command.FederationId,
                City = (command.CityId is not null)
                    ? await dictionaryItemRepository.Get(command.CityId.Value)
                    : null,
                Hall = (command.HallId is not null)
                    ? await dictionaryItemRepository.Get(command.HallId.Value)
                    : null,
            };

            return await eventRepository.Create(myEvent);
        }

        private async Task ValidateCommand(
            CreateEvent.Command command,
            IStringLocalizer<ApiValidationMessage> localizer)
        {
            var federation = await federationRepository.Get(command.FederationId) ??
                             throw new MyNotFoundException();

            if (command.CityId is not null)
            {
                var isCityValid =
                    await dictionaryService.ItemIsFromDictionary(command.CityId.Value, DictionaryCode.City);
                if (!isCityValid)
                {
                    throw new MyValidationException(nameof(CreateEvent.Command.CityId),
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
                    throw new MyValidationException(nameof(CreateEvent.Command.HallId),
                        localizer[nameof(ApiValidationMessageString.DictionaryItemMustBeInDictionary),
                            DictionaryCode.Hall]);
                }
            }
        }
    }
}