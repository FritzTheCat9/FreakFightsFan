using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Fighters.Commands;
using FreakFightsFan.Shared.Features.Fighters.Queries;
using FreakFightsFan.Shared.Features.Fighters.Responses;

namespace FreakFightsFan.Blazor.Clients
{
    public interface IFighterApiClient
    {
        Task<PagedList<FighterDto>> GetAllFighters(GetAllFighters.Query query);
        Task<FighterDto> GetFighter(int id);
        Task CreateFighter(CreateFighter.Command command);
        Task UpdateFighter(UpdateFighter.Command command);
        Task DeleteFighter(int id);
    }

    public class FighterApiClient : IFighterApiClient
    {
        private readonly IApiClient _apiClient;
        private readonly string _url = "api/fighters";

        public FighterApiClient(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<PagedList<FighterDto>> GetAllFighters(GetAllFighters.Query query)
        {
            return await _apiClient.Post<GetAllFighters.Query, PagedList<FighterDto>>($"{_url}/all", query);
        }

        public async Task<FighterDto> GetFighter(int id)
        {
            return await _apiClient.Get<FighterDto>($"{_url}/{id}");
        }

        public async Task CreateFighter(CreateFighter.Command command)
        {
            await _apiClient.Post(_url, command);
        }

        public async Task UpdateFighter(UpdateFighter.Command command)
        {
            await _apiClient.Put($"{_url}/{command.Id}", command);
        }

        public async Task DeleteFighter(int id)
        {
            await _apiClient.Delete($"{_url}/{id}");
        }
    }
}
