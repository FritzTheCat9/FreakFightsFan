using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Events.Commands;
using FreakFightsFan.Shared.Features.Events.Queries;
using FreakFightsFan.Shared.Features.Events.Responses;

namespace FreakFightsFan.Blazor.Clients;

public interface IEventApiClient
{
    Task<PagedList<EventDto>> GetAllEvents(GetAllEvents.Query query);
    Task<EventDto> GetEvent(int id);
    Task CreateEvent(CreateEvent.Command command);
    Task UpdateEvent(UpdateEvent.Command command);
    Task DeleteEvent(int id);
}

public class EventApiClient(IApiClient apiClient) : IEventApiClient
{
    private const string _url = "api/events";

    public async Task<PagedList<EventDto>> GetAllEvents(GetAllEvents.Query query)
    {
        return await apiClient.Post<GetAllEvents.Query, PagedList<EventDto>>($"{_url}/all", query);
    }

    public async Task<EventDto> GetEvent(int id)
    {
        return await apiClient.Get<EventDto>($"{_url}/{id}");
    }

    public async Task CreateEvent(CreateEvent.Command command)
    {
        await apiClient.Post(_url, command);
    }

    public async Task UpdateEvent(UpdateEvent.Command command)
    {
        await apiClient.Put($"{_url}/{command.Id}", command);
    }

    public async Task DeleteEvent(int id)
    {
        await apiClient.Delete($"{_url}/{id}");
    }
}