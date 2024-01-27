using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Localization;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Dictionaries.Helpers;
using FreakFightsFan.Shared.Features.Events.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Api.Features.Events.Commands
{
    public static class CreateEventFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/events", async (
                CreateEvent.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                int eventId = await mediator.Send(command, cancellationToken);
                return Results.CreatedAtRoute("GetEvent", new { id = eventId });
            })
                .WithTags("Events")
                .RequireAuthorization(Policy.Admin);

            return app;
        }

        public class Handler : IRequestHandler<CreateEvent.Command, int>
        {
            private readonly IEventRepository _eventRepository;
            private readonly IFederationRepository _federationRepository;
            private readonly IClock _clock;
            private readonly IMyDictionaryItemRepository _dictionaryItemRepository;
            private readonly IMyDictionaryService _dictionaryService;
            private readonly IStringLocalizer<ApiValidationMessage> _localizer;

            public Handler(
                IEventRepository eventRepository,
                IFederationRepository federationRepository,
                IClock clock,
                IMyDictionaryItemRepository dictionaryItemRepository,
                IMyDictionaryService dictionaryService,
                IStringLocalizer<ApiValidationMessage> localizer)
            {
                _eventRepository = eventRepository;
                _federationRepository = federationRepository;
                _clock = clock;
                _dictionaryItemRepository = dictionaryItemRepository;
                _dictionaryService = dictionaryService;
                _localizer = localizer;
            }

            public async Task<int> Handle(
                CreateEvent.Command command,
                CancellationToken cancellationToken)
            {
                await ValidateCommand(command, _localizer);

                var myEvent = new Event
                {
                    Id = 0,
                    Created = _clock.Current(),
                    Modified = _clock.Current(),
                    Name = command.Name,
                    Date = command.Date.GetValueOrDefault(_clock.Current()),
                    FederationId = command.FederationId,
                    City = (command.CityId is not null) ? await _dictionaryItemRepository.Get(command.CityId.Value) : null,
                    Hall = (command.HallId is not null) ? await _dictionaryItemRepository.Get(command.HallId.Value) : null,
                };

                return await _eventRepository.Create(myEvent);
            }

            private async Task ValidateCommand(
                CreateEvent.Command command,
                IStringLocalizer<ApiValidationMessage> localizer)
            {
                var federation = await _federationRepository.Get(command.FederationId) ?? throw new MyNotFoundException();

                if (command.CityId is not null)
                {
                    var isCityValid = await _dictionaryService.ItemIsFromDictionary(command.CityId.Value, DictionaryCode.City);
                    if (!isCityValid)
                        throw new MyValidationException(nameof(CreateEvent.Command.CityId),
                            localizer[nameof(ApiValidationMessageString.DictionaryItemMustBeInDictionary), DictionaryCode.City]);
                }

                if (command.HallId is not null)
                {
                    var isHallValid = await _dictionaryService.ItemIsFromDictionary(command.HallId.Value, DictionaryCode.Hall);
                    if (!isHallValid)
                        throw new MyValidationException(nameof(CreateEvent.Command.HallId),
                            localizer[nameof(ApiValidationMessageString.DictionaryItemMustBeInDictionary), DictionaryCode.Hall]);
                }
            }
        }
    }
}
