using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Federations.Commands;
using FreakFightsFan.Shared.Features.Federations.Queries;
using FreakFightsFan.Shared.Features.Federations.Responses;

namespace FreakFightsFan.Blazor.Clients;

public interface IFederationApiClient
{
    Task<PagedList<FederationDto>> GetAllFederations(GetAllFederations.Query query);
    Task<FederationDto> GetFederation(int id);
    Task CreateFederation(CreateFederation.Command command);
    Task UpdateFederation(UpdateFederation.Command command);
    Task DeleteFederation(int id);
}

public class FederationApiClient(IApiClient apiClient) : IFederationApiClient
{
    private const string _url = "api/federations";

    public async Task<PagedList<FederationDto>> GetAllFederations(GetAllFederations.Query query)
    {
        return await apiClient.Post<GetAllFederations.Query, PagedList<FederationDto>>($"{_url}/all", query);
    }

    public async Task<FederationDto> GetFederation(int id)
    {
        return await apiClient.Get<FederationDto>($"{_url}/{id}");
    }

    public async Task CreateFederation(CreateFederation.Command command)
    {
        await apiClient.Post(_url, command);
    }

    public async Task UpdateFederation(UpdateFederation.Command command)
    {
        await apiClient.Put($"{_url}/{command.Id}", command);
    }

    public async Task DeleteFederation(int id)
    {
        await apiClient.Delete($"{_url}/{id}");
    }
}