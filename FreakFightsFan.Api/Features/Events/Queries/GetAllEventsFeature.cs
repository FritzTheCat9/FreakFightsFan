using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Extensions;
using FreakFightsFan.Api.Features.Events.Extensions;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Events.Queries;
using FreakFightsFan.Shared.Features.Events.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Events.Queries;

public static class GetAllEventsFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapPost("/api/events/all", async (
                GetAllEvents.Query query,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
            .WithTags(Tags.Events)
            .AllowAnonymous();
    }

    public class Handler(IEventRepository eventRepository)
        : IRequestHandler<GetAllEvents.Query, PagedList<EventDto>>
    {
        public async Task<PagedList<EventDto>> Handle(
            GetAllEvents.Query query,
            CancellationToken cancellationToken)
        {
            var eventsQuery = eventRepository.AsQueryable(query.FederationId);

            eventsQuery = eventsQuery.FilterEvents(query);
            eventsQuery = eventsQuery.SortEvents(query);

            var eventsPagedList = PageListExtensions<EventDto>.Create(
                eventsQuery.Select(x => x.ToDto()),
                query.Page,
                query.PageSize);

            return await Task.FromResult(eventsPagedList);
        }
    }
}