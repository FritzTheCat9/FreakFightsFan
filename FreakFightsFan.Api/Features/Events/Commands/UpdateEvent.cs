using Carter;
using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Dictionaries.Helpers;
using FreakFightsFan.Shared.Features.Events.Requests;
using MediatR;

namespace FreakFightsFan.Api.Features.Events.Commands
{
    public static class UpdateEvent
    {
        public class Command : IRequest<Unit>
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime? Date { get; set; }
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

        public class Handler : IRequestHandler<Command, Unit>
        {
            private readonly IEventRepository _eventRepository;
            private readonly IClock _clock;
            private readonly IMyDictionaryItemRepository _dictionaryItemRepository;
            private readonly IMyDictionaryService _dictionaryService;

            public Handler(IEventRepository eventRepository, IClock clock,
                IMyDictionaryItemRepository dictionaryItemRepository, IMyDictionaryService dictionaryService)
            {
                _eventRepository = eventRepository;
                _clock = clock;
                _dictionaryItemRepository = dictionaryItemRepository;
                _dictionaryService = dictionaryService;
            }

            public async Task<Unit> Handle(Command command, CancellationToken cancellationToken)
            {
                var myEvent = await _eventRepository.Get(command.Id) ?? throw new MyNotFoundException();

                if (command.CityId is not null)
                {
                    var isCityValid = await _dictionaryService.ItemIsFromDictionary(command.CityId.Value, DictionaryCode.City);
                    if (!isCityValid) 
                        throw new MyValidationException("CityId", $"Dictionary item should be chosen from dictionary with code: {DictionaryCode.City}");
                }

                myEvent.Modified = _clock.Current();
                myEvent.Name = command.Name;
                myEvent.Date = command.Date.GetValueOrDefault(_clock.Current());
                myEvent.City = (command.CityId is not null) ? await _dictionaryItemRepository.Get(command.CityId.Value) : null;

                await _eventRepository.Update(myEvent);
                return Unit.Value;
            }
        }
    }

    public class UpdateEventEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPut("/api/events/{id}", async (
                int id,
                UpdateEventRequest updateEventRequest,
                IMediator mediator,
                CancellationToken cancellationToken) =>
                {
                    var command = new UpdateEvent.Command()
                    {
                        Id = id,
                        Name = updateEventRequest.Name,
                        Date = updateEventRequest.Date,
                        CityId = updateEventRequest.CityId,
                    };

                    return Results.Ok(await mediator.Send(command, cancellationToken));
                })
                .WithTags("Events");
        }
    }
}
