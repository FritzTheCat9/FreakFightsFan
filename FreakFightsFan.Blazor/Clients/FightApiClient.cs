using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Fights.Requests;
using FreakFightsFan.Shared.Features.Fights.Responses;

namespace FreakFightsFan.Blazor.Clients
{
    public interface IFightApiClient
    {
        Task<PagedList<FightDto>> GetAllFights(GetAllFightsRequest getAllFightsRequest);
        Task<FightDto> GetFight(int id);
        Task CreateFight(CreateFightRequest createFightRequest);
        Task UpdateFight(UpdateFightRequest updateFightRequest);
        Task DeleteFight(int id);
        Task MoveFight(MoveFightRequest moveFightRequest);
    }

    public class FightApiClient : IFightApiClient
    {
        private readonly IApiClient _apiClient;
        private readonly string _url = "api/fights";

        public FightApiClient(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<PagedList<FightDto>> GetAllFights(GetAllFightsRequest getAllFightsRequest)
        {
            return await _apiClient.Post<GetAllFightsRequest, PagedList<FightDto>>(_url + "/all", getAllFightsRequest);
        }

        public async Task<FightDto> GetFight(int id)
        {
            return await _apiClient.Get<FightDto>(_url + id);
        }

        public async Task CreateFight(CreateFightRequest createFightRequest)
        {
            await _apiClient.Post(_url, createFightRequest);
        }

        public async Task UpdateFight(UpdateFightRequest updateFightRequest)
        {
            await _apiClient.Put(_url + "/" + updateFightRequest.Id, updateFightRequest);
        }

        public async Task DeleteFight(int id)
        {
            await _apiClient.Delete(_url + "/" + id);
        }

        public async Task MoveFight(MoveFightRequest moveFightRequest)
        {
            await _apiClient.Put(_url + "/move/" + moveFightRequest.Id, moveFightRequest);
        }
    }
}
