using Carter;
using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Exceptions;
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
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator()
            {
                RuleFor(x => x.Name)
                    .NotEmpty();
            }
        }

        public class Handler : IRequestHandler<Command, Unit>
        {
            private readonly IEventRepository _eventRepository;
            private readonly IClock _clock;

            public Handler(IEventRepository eventRepository, IClock clock)
            {
                _eventRepository = eventRepository;
                _clock = clock;
            }

            public async Task<Unit> Handle(Command command, CancellationToken cancellationToken)
            {
                var myEvent = await _eventRepository.Get(command.Id) ?? throw new MyNotFoundException();
                myEvent.Modified = _clock.Current();
                myEvent.Name = command.Name;

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
                    };

                    return Results.Ok(await mediator.Send(command, cancellationToken));
                })
                .WithTags("Events");
        }
    }
}
