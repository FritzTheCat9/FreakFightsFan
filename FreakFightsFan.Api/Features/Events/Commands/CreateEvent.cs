using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Events.Extensions;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Dictionaries.Helpers;
using FreakFightsFan.Shared.Features.Events.Requests;
using MediatR;

namespace FreakFightsFan.Api.Features.Events.Commands
{
    public static class CreateEvent
    {
        public class Command : IRequest<int>
        {
            public string Name { get; set; }
            public DateTime? Date { get; set; }
            public int FederationId { get; set; }
            public int? CityId { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator()
            {
                RuleFor(x => x.Name)
                    .NotEmpty();

                RuleFor(x => x.Date)
                    .NotEmpty();
            }
        }

        public class Handler : IRequestHandler<Command, int>
        {
            private readonly IEventRepository _eventRepository;
            private readonly IFederationRepository _federationRepository;
            private readonly IClock _clock;
            private readonly IMyDictionaryItemRepository _dictionaryItemRepository;
            private readonly IMyDictionaryService _dictionaryService;

            public Handler(IEventRepository eventRepository, IFederationRepository federationRepository, IClock clock,
                IMyDictionaryItemRepository dictionaryItemRepository, IMyDictionaryService dictionaryService)
            {
                _eventRepository = eventRepository;
                _federationRepository = federationRepository;
                _clock = clock;
                _dictionaryItemRepository = dictionaryItemRepository;
                _dictionaryService = dictionaryService;
            }

            public async Task<int> Handle(Command command, CancellationToken cancellationToken)
            {
                var federation = await _federationRepository.Get(command.FederationId) ?? throw new MyNotFoundException();

                if (command.CityId is not null)
                {
                    var isCityValid = await _dictionaryService.ItemIsFromDictionary(command.CityId.Value, DictionaryCode.City);
                    if (!isCityValid)
                        throw new MyValidationException("CityId", $"Dictionary item should be chosen from dictionary with code: {DictionaryCode.City}");
                }

                var myEvent = new Event
                {
                    Id = 0,
                    Created = _clock.Current(),
                    Modified = _clock.Current(),
                    Name = command.Name,
                    Date = command.Date.GetValueOrDefault(_clock.Current()),
                    FederationId = command.FederationId,
                    City = (command.CityId is not null) ? await _dictionaryItemRepository.Get(command.CityId.Value) : null
                };

                return await _eventRepository.Create(myEvent);
            }
        }

        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/events", async (
                CreateEventRequest request,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                int eventId = await mediator.Send(request.ToCreateEventCommand(), cancellationToken);
                return Results.CreatedAtRoute("GetEvent", new { id = eventId });
            })
                .WithTags("Events");

            return app;
        }
    }
}