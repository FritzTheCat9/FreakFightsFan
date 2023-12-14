using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Fighters.Requests;
using FreakFightsFan.Shared.Features.Fighters.Responses;

namespace FreakFightsFan.Blazor.Clients
{
    public interface IFighterApiClient
    {
        Task<PagedList<FighterDto>> GetAllFighters(GetAllFightersRequest request);
        Task<FighterDto> GetFighter(int id);
        Task CreateFighter(CreateFighterRequest request);
        Task UpdateFighter(UpdateFighterRequest request);
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

        public async Task<PagedList<FighterDto>> GetAllFighters(GetAllFightersRequest request)
        {
            return await _apiClient.Post<GetAllFightersRequest, PagedList<FighterDto>>(_url + "/all", request);
        }

        public async Task<FighterDto> GetFighter(int id)
        {
            return await _apiClient.Get<FighterDto>(_url + "/" + id);
        }

        public async Task CreateFighter(CreateFighterRequest request)
        {
            await _apiClient.Post(_url, request);
        }

        public async Task UpdateFighter(UpdateFighterRequest request)
        {
            await _apiClient.Put(_url + "/" + request.Id, request);
        }

        public async Task DeleteFighter(int id)
        {
            await _apiClient.Delete(_url + "/" + id);
        }
    }
}
