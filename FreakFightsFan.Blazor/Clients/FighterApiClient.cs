using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Fighters.Requests;
using FreakFightsFan.Shared.Features.Fighters.Responses;

namespace FreakFightsFan.Blazor.Clients
{
    public interface IFighterApiClient
    {
        Task<PagedList<FighterDto>> GetAllFighters(GetAllFightersRequest getAllFightersRequest);
        Task<FighterDto> GetFighter(int id);
        Task CreateFighter(CreateFighterRequest createFighterRequest);
        Task UpdateFighter(UpdateFighterRequest updateFighterRequest);
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

        public async Task<PagedList<FighterDto>> GetAllFighters(GetAllFightersRequest getAllFightersRequest)
        {
            return await _apiClient.Post<GetAllFightersRequest, PagedList<FighterDto>>(_url + "/all", getAllFightersRequest);
        }

        public async Task<FighterDto> GetFighter(int id)
        {
            return await _apiClient.Get<FighterDto>(_url + id);
        }

        public async Task CreateFighter(CreateFighterRequest createFighterRequest)
        {
            await _apiClient.Post(_url, createFighterRequest);
        }

        public async Task UpdateFighter(UpdateFighterRequest updateFighterRequest)
        {
            await _apiClient.Put(_url + "/" + updateFighterRequest.Id, updateFighterRequest);
        }

        public async Task DeleteFighter(int id)
        {
            await _apiClient.Delete(_url + "/" + id);
        }
    }
}
