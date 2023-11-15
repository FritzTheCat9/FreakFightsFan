using Carter;
using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Events.Requests;
using MediatR;

namespace FreakFightsFan.Api.Features.Events.Commands
{
    public static class CreateEvent
    {
        public class Command : IRequest<int>
        {
            public string Name { get; set; }
            public int FederationId { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator()
            {
                RuleFor(x => x.Name)
                    .NotEmpty();
            }
        }

        public class Handler : IRequestHandler<Command, int>
        {
            private readonly IEventRepository _eventRepository;
            private readonly IFederationRepository _federationRepository;
            private readonly IClock _clock;

            public Handler(IEventRepository eventRepository, IFederationRepository federationRepository, IClock clock)
            {
                _eventRepository = eventRepository;
                _federationRepository = federationRepository;
                _clock = clock;
            }

            public async Task<int> Handle(Command command, CancellationToken cancellationToken)
            {
                var federation = await _federationRepository.Get(command.FederationId) ?? throw new MyNotFoundException();

                var myEvent = new Event
                {
                    Id = 0,
                    Created = _clock.Current(),
                    Modified = _clock.Current(),
                    Name = command.Name,
                    FederationId = command.FederationId
                };

                return await _eventRepository.Create(myEvent);
            }
        }
    }

    public class CreateEventEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/api/events", async (
                CreateEventRequest createEventRequest,
                IMediator mediator,
                CancellationToken cancellationToken) =>
                {
                    var command = new CreateEvent.Command()
                    {
                        Name = createEventRequest.Name,
                        FederationId = createEventRequest.FederationId
                    };

                    int eventId = await mediator.Send(command, cancellationToken);
                    return Results.CreatedAtRoute("GetEvent", new { id = eventId });
                })
                .WithTags("Events");
        }
    }
}
