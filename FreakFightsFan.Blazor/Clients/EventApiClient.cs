using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Events.Commands;
using FreakFightsFan.Shared.Features.Events.Queries;
using FreakFightsFan.Shared.Features.Events.Responses;

namespace FreakFightsFan.Blazor.Clients
{
    public interface IEventApiClient
    {
        Task<PagedList<EventDto>> GetAllEvents(GetAllEvents.Query query);
        Task<EventDto> GetEvent(int id);
        Task CreateEvent(CreateEvent.Command command);
        Task UpdateEvent(UpdateEvent.Command command);
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

        public async Task<PagedList<EventDto>> GetAllEvents(GetAllEvents.Query query)
            => await _apiClient.Post<GetAllEvents.Query, PagedList<EventDto>>($"{_url}/all", query);

        public async Task<EventDto> GetEvent(int id)
            => await _apiClient.Get<EventDto>($"{_url}/{id}");

        public async Task CreateEvent(CreateEvent.Command command)
            => await _apiClient.Post(_url, command);

        public async Task UpdateEvent(UpdateEvent.Command command)
            => await _apiClient.Put($"{_url}/{command.Id}", command);

        public async Task DeleteEvent(int id)
            => await _apiClient.Delete($"{_url}/{id}");
    }
}
