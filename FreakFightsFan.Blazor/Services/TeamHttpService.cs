using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Teams.Requests;
using FreakFightsFan.Shared.Features.Teams.Responses;

namespace FreakFightsFan.Blazor.Services
{
    public interface ITeamHttpService
    {
        Task<PagedList<TeamDto>> GetAllTeams(GetAllTeamsRequest getAllTeamsRequest);
        Task<TeamDto> GetTeam(int id);
        Task CreateTeam(CreateTeamRequest createTeamRequest);
        Task UpdateTeam(UpdateTeamRequest updateTeamRequest);
        Task DeleteTeam(int id);
    }

    public class TeamHttpService : ITeamHttpService
    {
        private readonly IHttpService _httpService;
        private readonly string _url = "api/teams";

        public TeamHttpService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<PagedList<TeamDto>> GetAllTeams(GetAllTeamsRequest getAllTeamsRequest)
        {
            return await _httpService.Post<GetAllTeamsRequest, PagedList<TeamDto>>(_url + "/all", getAllTeamsRequest);
        }

        public async Task<TeamDto> GetTeam(int id)
        {
            return await _httpService.Get<TeamDto>(_url + id);
        }

        public async Task CreateTeam(CreateTeamRequest createTeamRequest)
        {
            await _httpService.Post(_url, createTeamRequest);
        }

        public async Task UpdateTeam(UpdateTeamRequest updateTeamRequest)
        {
            await _httpService.Put(_url + "/" + updateTeamRequest.Id, updateTeamRequest);
        }

        public async Task DeleteTeam(int id)
        {
            await _httpService.Delete(_url + "/" + id);
        }
    }
}
