using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Fighters.Requests;
using FreakFightsFan.Shared.Features.Fighters.Responses;

namespace FreakFightsFan.Blazor.Services
{
    public interface IFighterHttpService
    {
        Task<PagedList<FighterDto>> GetAllFighters(GetAllFightersRequest getAllFightersRequest);
        Task<FighterDto> GetFighter(int id);
        Task CreateFighter(CreateFighterRequest createFighterRequest);
        Task UpdateFighter(UpdateFighterRequest updateFighterRequest);
        Task DeleteFighter(int id);
    }

    public class FighterHttpService : IFighterHttpService
    {
        private readonly IHttpService _httpService;
        private readonly string _url = "api/fighters";

        public FighterHttpService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<PagedList<FighterDto>> GetAllFighters(GetAllFightersRequest getAllFightersRequest)
        {
            return await _httpService.Post<GetAllFightersRequest, PagedList<FighterDto>>(_url + "/all", getAllFightersRequest);
        }

        public async Task<FighterDto> GetFighter(int id)
        {
            return await _httpService.Get<FighterDto>(_url + id);
        }

        public async Task CreateFighter(CreateFighterRequest createFighterRequest)
        {
            await _httpService.Post(_url, createFighterRequest);
        }

        public async Task UpdateFighter(UpdateFighterRequest updateFighterRequest)
        {
            await _httpService.Put(_url + "/" + updateFighterRequest.Id, updateFighterRequest);
        }

        public async Task DeleteFighter(int id)
        {
            await _httpService.Delete(_url + "/" + id);
        }
    }
}
