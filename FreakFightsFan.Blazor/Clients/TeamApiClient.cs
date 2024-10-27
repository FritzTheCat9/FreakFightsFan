using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Teams.Queries;
using FreakFightsFan.Shared.Features.Teams.Responses;

namespace FreakFightsFan.Blazor.Clients;

public interface ITeamApiClient
{
    Task<PagedList<TeamDto>> GetAllTeams(GetAllTeams.Query query);
    Task<TeamDto> GetTeam(int id);
}

public class TeamApiClient(IApiClient apiClient) : ITeamApiClient
{
    private const string _url = "api/teams";

    public async Task<PagedList<TeamDto>> GetAllTeams(GetAllTeams.Query query)
    {
        return await apiClient.Post<GetAllTeams.Query, PagedList<TeamDto>>($"{_url}/all", query);
    }

    public async Task<TeamDto> GetTeam(int id)
    {
        return await apiClient.Get<TeamDto>($"{_url}/{id}");
    }
}