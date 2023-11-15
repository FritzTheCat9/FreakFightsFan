using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Events.Requests;
using FreakFightsFan.Shared.Features.Events.Responses;

namespace FreakFightsFan.Blazor.Services
{
    public interface IEventHttpService
    {
        Task<PagedList<EventDto>> GetAllEvents(GetAllEventsRequest getAllEventsRequest);
        Task<EventDto> GetEvent(int id);
        Task CreateEvent(CreateEventRequest createEventRequest);
        Task UpdateEvent(UpdateEventRequest updateEventRequest);
        Task DeleteEvent(int id);
    }

    public class EventHttpService : IEventHttpService
    {
        private readonly IHttpService _httpService;
        private readonly string _url = "api/events";

        public EventHttpService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<PagedList<EventDto>> GetAllEvents(GetAllEventsRequest getAllEventsRequest)
        {
            return await _httpService.Post<GetAllEventsRequest, PagedList<EventDto>>(_url + "/all", getAllEventsRequest);
        }

        public async Task<EventDto> GetEvent(int id)
        {
            return await _httpService.Get<EventDto>(_url + id);
        }

        public async Task CreateEvent(CreateEventRequest createEventRequest)
        {
            await _httpService.Post(_url, createEventRequest);
        }

        public async Task UpdateEvent(UpdateEventRequest updateEventRequest)
        {
            await _httpService.Put(_url + "/" + updateEventRequest.Id, updateEventRequest);
        }

        public async Task DeleteEvent(int id)
        {
            await _httpService.Delete(_url + "/" + id);
        }
    }
}
