using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Teams.Requests;
using FreakFightsFan.Shared.Features.Teams.Responses;

namespace FreakFightsFan.Blazor.Clients
{
    public interface ITeamApiClient
    {
        Task<PagedList<TeamDto>> GetAllTeams(GetAllTeamsRequest request);
        Task<TeamDto> GetTeam(int id);
    }

    public class TeamApiClient : ITeamApiClient
    {
        private readonly IApiClient _apiClient;
        private readonly string _url = "api/teams";

        public TeamApiClient(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<PagedList<TeamDto>> GetAllTeams(GetAllTeamsRequest request)
        {
            return await _apiClient.Post<GetAllTeamsRequest, PagedList<TeamDto>>($"{_url}/all", request);
        }

        public async Task<TeamDto> GetTeam(int id)
        {
            return await _apiClient.Get<TeamDto>($"{_url}/{id}");
        }
    }
}
