using Carter;
using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Events.Extensions;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Events.Requests;
using FreakFightsFan.Shared.Features.Events.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Events.Queries
{
    public static class GetAllEvents
    {
        public class Query : IRequest<PagedList<EventDto>>, IPagedQuery, ISortedQuery
        {
            public int Page { get; set; }
            public int PageSize { get; set; }
            public string SortColumn { get; set; }
            public SortOrder SortOrder { get; set; }
            public string SearchTerm { get; set; }

            public int FederationId { get; set; }
        }

        public class Validator : AbstractValidator<Query>
        {

        }

        public class Handler : IRequestHandler<Query, PagedList<EventDto>>
        {
            private readonly IEventRepository _eventRepository;

            public Handler(IEventRepository eventRepository)
            {
                _eventRepository = eventRepository;
            }

            public async Task<PagedList<EventDto>> Handle(Query query, CancellationToken cancellationToken)
            {
                var eventsQuery = _eventRepository.AsQueryable(query.FederationId);

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

    public class GetAllEventsEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/api/events/all", async (
                GetAllEventsRequest getAllEventsRequest,
                IMediator mediator,
                CancellationToken cancellationToken) =>
                {
                    var query = new GetAllEvents.Query()
                    {
                        Page = getAllEventsRequest.Page,
                        PageSize = getAllEventsRequest.PageSize,
                        SortOrder = getAllEventsRequest.SortOrder,
                        SortColumn = getAllEventsRequest.SortColumn,
                        SearchTerm = getAllEventsRequest.SearchTerm,
                        FederationId = getAllEventsRequest.FederationId,
                    };

                    return Results.Ok(await mediator.Send(query, cancellationToken));
                })
                .WithTags("Events");
        }
    }
}
