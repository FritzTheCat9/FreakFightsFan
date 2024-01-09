using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Fights.Commands;
using FreakFightsFan.Shared.Features.Fights.Queries;
using FreakFightsFan.Shared.Features.Fights.Responses;

namespace FreakFightsFan.Blazor.Clients
{
    public interface IFightApiClient
    {
        Task<PagedList<FightDto>> GetAllFights(GetAllFights.Query query);
        Task<FighterProfileDto> GetFighterProfile(int id);
        Task<FightDto> GetFight(int id);
        Task CreateFight(CreateFight.Command command);
        Task UpdateFight(UpdateFight.Command command);
        Task DeleteFight(int id);
        Task MoveFight(MoveFight.Command command);
    }

    public class FightApiClient : IFightApiClient
    {
        private readonly IApiClient _apiClient;
        private readonly string _url = "api/fights";

        public FightApiClient(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<PagedList<FightDto>> GetAllFights(GetAllFights.Query query)
        {
            return await _apiClient.Post<GetAllFights.Query, PagedList<FightDto>>($"{_url}/all", query);
        }

        public async Task<FighterProfileDto> GetFighterProfile(int id)
        {
            return await _apiClient.Get<FighterProfileDto>($"{_url}/fighter/{id}");
        }

        public async Task<FightDto> GetFight(int id)
        {
            return await _apiClient.Get<FightDto>($"{_url}/{id}");
        }

        public async Task CreateFight(CreateFight.Command command)
        {
            await _apiClient.Post(_url, command);
        }

        public async Task UpdateFight(UpdateFight.Command command)
        {
            await _apiClient.Put($"{_url}/{command.Id}", command);
        }

        public async Task DeleteFight(int id)
        {
            await _apiClient.Delete($"{_url}/{id}");
        }

        public async Task MoveFight(MoveFight.Command command)
        {
            await _apiClient.Put($"{_url}/move/{command.Id}", command);
        }
    }
}
