using Carter;
using FluentValidation;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Exceptions;
using MediatR;

namespace FreakFightsFan.Api.Features.Events.Commands
{
    public static class DeleteEvent
    {
        public class Command : IRequest<Unit>
        {
            public int Id { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {

        }

        public class Handler : IRequestHandler<Command, Unit>
        {
            private readonly IEventRepository _eventRepository;

            public Handler(IEventRepository eventRepository)
            {
                _eventRepository = eventRepository;
            }

            public async Task<Unit> Handle(Command command, CancellationToken cancellationToken)
            {
                var myEvent = await _eventRepository.Get(command.Id) ?? throw new MyNotFoundException();
                await _eventRepository.Delete(myEvent);
                return Unit.Value;
            }
        }
    }

    public class DeleteEventEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapDelete("/api/events/{id}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
                {
                    var command = new DeleteEvent.Command() { Id = id };
                    return Results.Ok(await mediator.Send(command, cancellationToken));
                })
                .WithTags("Events");
        }
    }
}
