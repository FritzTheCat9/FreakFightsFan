using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Events.Requests;
using FreakFightsFan.Shared.Features.Events.Responses;

namespace FreakFightsFan.Blazor.Clients
{
    public interface IEventApiClient
    {
        Task<PagedList<EventDto>> GetAllEvents(GetAllEventsRequest getAllEventsRequest);
        Task<EventDto> GetEvent(int id);
        Task CreateEvent(CreateEventRequest createEventRequest);
        Task UpdateEvent(UpdateEventRequest updateEventRequest);
        Task DeleteEvent(int id);
    }

    public class EventApiClient : IEventApiClient
    {
        private readonly IApiClient _apiClient;
        private readonly string _url = "api/events";

        public EventApiClient(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<PagedList<EventDto>> GetAllEvents(GetAllEventsRequest getAllEventsRequest)
        {
            return await _apiClient.Post<GetAllEventsRequest, PagedList<EventDto>>(_url + "/all", getAllEventsRequest);
        }

        public async Task<EventDto> GetEvent(int id)
        {
            return await _apiClient.Get<EventDto>(_url + id);
        }

        public async Task CreateEvent(CreateEventRequest createEventRequest)
        {
            await _apiClient.Post(_url, createEventRequest);
        }

        public async Task UpdateEvent(UpdateEventRequest updateEventRequest)
        {
            await _apiClient.Put(_url + "/" + updateEventRequest.Id, updateEventRequest);
        }

        public async Task DeleteEvent(int id)
        {
            await _apiClient.Delete(_url + "/" + id);
        }
    }
}
