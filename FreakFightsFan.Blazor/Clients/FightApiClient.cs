using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Fights.Requests;
using FreakFightsFan.Shared.Features.Fights.Responses;

namespace FreakFightsFan.Blazor.Clients
{
    public interface IFightApiClient
    {
        Task<PagedList<FightDto>> GetAllFights(GetAllFightsRequest request);
        Task<FighterProfileDto> GetFighterProfile(int id);
        Task<FightDto> GetFight(int id);
        Task CreateFight(CreateFightRequest request);
        Task UpdateFight(UpdateFightRequest request);
        Task DeleteFight(int id);
        Task MoveFight(MoveFightRequest request);
    }

    public class FightApiClient : IFightApiClient
    {
        private readonly IApiClient _apiClient;
        private readonly string _url = "api/fights";

        public FightApiClient(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<PagedList<FightDto>> GetAllFights(GetAllFightsRequest request)
        {
            return await _apiClient.Post<GetAllFightsRequest, PagedList<FightDto>>(_url + "/all", request);
        }

        public async Task<FighterProfileDto> GetFighterProfile(int id)
        {
            return await _apiClient.Get<FighterProfileDto>(_url + "/fighter/" + id);
        }

        public async Task<FightDto> GetFight(int id)
        {
            return await _apiClient.Get<FightDto>(_url + "/" + id);
        }

        public async Task CreateFight(CreateFightRequest request)
        {
            await _apiClient.Post(_url, request);
        }

        public async Task UpdateFight(UpdateFightRequest request)
        {
            await _apiClient.Put(_url + "/" + request.Id, request);
        }

        public async Task DeleteFight(int id)
        {
            await _apiClient.Delete(_url + "/" + id);
        }

        public async Task MoveFight(MoveFightRequest request)
        {
            await _apiClient.Put(_url + "/move/" + request.Id, request);
        }
    }
}
