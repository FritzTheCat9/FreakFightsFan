using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Events.Extensions;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Events.Queries;
using FreakFightsFan.Shared.Features.Events.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Events.Queries
{
    public static class GetEventFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapGet("/api/events/{id}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var query = new GetEvent.Query() { Id = id };
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
                .WithName("GetEvent")
                .WithTags("Events")
                .AllowAnonymous();

            return app;
        }

        public class Handler : IRequestHandler<GetEvent.Query, EventDto>
        {
            private readonly IEventRepository _eventRepository;

            public Handler(IEventRepository eventRepository)
            {
                _eventRepository = eventRepository;
            }

            public async Task<EventDto> Handle(
                GetEvent.Query query,
                CancellationToken cancellationToken)
            {
                var myEvent = await _eventRepository.Get(query.Id) ?? throw new MyNotFoundException();
                return myEvent.ToDto();
            }
        }
    }
}
