using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Events.Requests;
using FreakFightsFan.Shared.Features.Events.Responses;

namespace FreakFightsFan.Blazor.Clients
{
    public interface IEventApiClient
    {
        Task<PagedList<EventDto>> GetAllEvents(GetAllEventsRequest request);
        Task<EventDto> GetEvent(int id);
        Task CreateEvent(CreateEventRequest request);
        Task UpdateEvent(UpdateEventRequest request);
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

        public async Task<PagedList<EventDto>> GetAllEvents(GetAllEventsRequest request)
        {
            return await _apiClient.Post<GetAllEventsRequest, PagedList<EventDto>>($"{_url}/all", request);
        }

        public async Task<EventDto> GetEvent(int id)
        {
            return await _apiClient.Get<EventDto>($"{_url}/{id}");
        }

        public async Task CreateEvent(CreateEventRequest request)
        {
            await _apiClient.Post(_url, request);
        }

        public async Task UpdateEvent(UpdateEventRequest request)
        {
            await _apiClient.Put($"{_url}/{request.Id}", request);
        }

        public async Task DeleteEvent(int id)
        {
            await _apiClient.Delete($"{_url}/{id}");
        }
    }
}
