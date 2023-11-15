using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Features.Events.Queries;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Events.Responses;
using System.Linq.Expressions;

namespace FreakFightsFan.Api.Features.Events.Extensions
{
    public static class EventsExtensions
    {
        public static EventDto ToDto(this Event myEvent)
        {
            return new EventDto
            {
                Id = myEvent.Id,
                Created = myEvent.Created,
                Modified = myEvent.Modified,
                Name = myEvent.Name,
                FederationId = myEvent.FederationId,
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
                SortOrder.None => events,
                _ => events,
            };
        }

        private static Expression<Func<Event, object>> GetEventSortProperty(GetAllEvents.Query query)
        {
            return query.SortColumn.ToLowerInvariant() switch
            {
                "name" => myEvent => myEvent.Name,
                _ => myEvent => myEvent.Name,
            };
        }
    }
}
