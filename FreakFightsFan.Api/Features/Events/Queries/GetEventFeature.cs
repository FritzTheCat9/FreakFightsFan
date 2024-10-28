using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Events.Extensions;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Events.Queries;
using FreakFightsFan.Shared.Features.Events.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Events.Queries;

public static class GetEventFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapGet("/api/events/{id:int}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var query = new GetEvent.Query { Id = id };
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
            .WithName("GetEvent")
            .WithTags(Tags.Events)
            .AllowAnonymous();
    }

    public class Handler(IEventRepository eventRepository) : IRequestHandler<GetEvent.Query, EventDto>
    {
        public async Task<EventDto> Handle(
            GetEvent.Query query,
            CancellationToken cancellationToken)
        {
            var myEvent = await eventRepository.Get(query.Id) ?? throw new MyNotFoundException();
            return myEvent.ToDto();
        }
    }
}