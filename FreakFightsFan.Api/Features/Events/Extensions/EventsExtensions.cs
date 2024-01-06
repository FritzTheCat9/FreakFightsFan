using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Features.DictionaryItems.Extensions;
using FreakFightsFan.Api.Features.Events.Commands;
using FreakFightsFan.Api.Features.Events.Queries;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Events.Requests;
using FreakFightsFan.Shared.Features.Events.Responses;
using System.Linq.Expressions;

namespace FreakFightsFan.Api.Features.Events.Extensions
{
    public static class EventsExtensions
    {
        public static IEndpointRouteBuilder AddEventEndpoints(this IEndpointRouteBuilder app)
        {
            CreateEvent.Endpoint(app);
            DeleteEvent.Endpoint(app);
            UpdateEvent.Endpoint(app);
            GetAllEvents.Endpoint(app);
            GetEvent.Endpoint(app);

            return app;
        }

        public static EventDto ToDto(this Event myEvent)
        {
            return new()
            {
                Id = myEvent.Id,
                Created = myEvent.Created,
                Modified = myEvent.Modified,
                Name = myEvent.Name,
                Date = myEvent.Date,
                FederationId = myEvent.FederationId,
                City = myEvent.City?.ToDto(),
                Hall = myEvent.Hall?.ToDto(),
            };
        }

        public static CreateEvent.Command ToCreateEventCommand(this CreateEventRequest request)
        {
            return new()
            {
                Name = request.Name,
                Date = request.Date,
                FederationId = request.FederationId,
                CityId = request.CityId,
                HallId = request.HallId,
            };
        }

        public static UpdateEvent.Command ToUpdateEventCommand(this UpdateEventRequest request, int id)
        {
            return new()
            {
                Id = id,
                Name = request.Name,
                Date = request.Date,
                CityId = request.CityId,
                HallId = request.HallId,
            };
        }

        public static GetAllEvents.Query ToGetAllEventsQuery(this GetAllEventsRequest request)
        {
            return new()
            {
                Page = request.Page,
                PageSize = request.PageSize,
                SortOrder = request.SortOrder,
                SortColumn = request.SortColumn,
                SearchTerm = request.SearchTerm,
                FederationId = request.FederationId,
            };
        }

        public static IQueryable<Event> FilterEvents(this IQueryable<Event> events, GetAllEvents.Query query)
        {
            var searchTerm = query.SearchTerm.ToLower().Trim();
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                events = events.Where(x =>
                    x.Name.ToLower().Contains(searchTerm));
            }
            return events;
        }

        public static IQueryable<Event> SortEvents(this IQueryable<Event> events, GetAllEvents.Query query)
        {
            return query.SortOrder switch
            {
                SortOrder.Ascending => events.OrderBy(GetEventSortProperty(query)),
                SortOrder.Descending => events.OrderByDescending(GetEventSortProperty(query)),
                SortOrder.None => events.OrderByDescending(myEvent => myEvent.Date),
                _ => events.OrderByDescending(myEvent => myEvent.Date),
            };
        }

        private static Expression<Func<Event, object>> GetEventSortProperty(GetAllEvents.Query query)
        {
            return query.SortColumn.ToLowerInvariant() switch
            {
                "name" => myEvent => myEvent.Name,
                "date" => myEvent => myEvent.Date,
                "city" => myEvent => myEvent.City.Name,
                "hall" => myEvent => myEvent.Hall.Name,
                _ => myEvent => myEvent.Date,
            };
        }
    }
}
