using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Features.DictionaryItems.Extensions;
using FreakFightsFan.Api.Features.Events.Commands;
using FreakFightsFan.Api.Features.Events.Queries;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Events.Queries;
using FreakFightsFan.Shared.Features.Events.Responses;
using System.Linq.Expressions;

namespace FreakFightsFan.Api.Features.Events.Extensions
{
    public static class EventsExtensions
    {
        public static IEndpointRouteBuilder AddEventEndpoints(this IEndpointRouteBuilder app)
        {
            CreateEventFeature.Endpoint(app);
            DeleteEventFeature.Endpoint(app);
            UpdateEventFeature.Endpoint(app);
            GetAllEventsFeature.Endpoint(app);
            GetEventFeature.Endpoint(app);

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
