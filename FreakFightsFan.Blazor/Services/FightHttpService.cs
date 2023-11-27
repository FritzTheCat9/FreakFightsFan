using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Fights.Requests;
using FreakFightsFan.Shared.Features.Fights.Responses;

namespace FreakFightsFan.Blazor.Services
{
    public interface IFightHttpService
    {
        Task<PagedList<FightDto>> GetAllFights(GetAllFightsRequest getAllFightsRequest);
        Task<FightDto> GetFight(int id);
        Task CreateFight(CreateFightRequest createFightRequest);
        Task UpdateFight(UpdateFightRequest updateFightRequest);
        Task DeleteFight(int id);
    }

    public class FightHttpService : IFightHttpService
    {
        private readonly IHttpService _httpService;
        private readonly string _url = "api/fights";

        public FightHttpService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<PagedList<FightDto>> GetAllFights(GetAllFightsRequest getAllFightsRequest)
        {
            return await _httpService.Post<GetAllFightsRequest, PagedList<FightDto>>(_url + "/all", getAllFightsRequest);
        }

        public async Task<FightDto> GetFight(int id)
        {
            return await _httpService.Get<FightDto>(_url + id);
        }

        public async Task CreateFight(CreateFightRequest createFightRequest)
        {
            await _httpService.Post(_url, createFightRequest);
        }

        public async Task UpdateFight(UpdateFightRequest updateFightRequest)
        {
            await _httpService.Put(_url + "/" + updateFightRequest.Id, updateFightRequest);
        }

        public async Task DeleteFight(int id)
        {
            await _httpService.Delete(_url + "/" + id);
        }
    }
}
