using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Federations.Commands;
using FreakFightsFan.Shared.Features.Federations.Queries;
using FreakFightsFan.Shared.Features.Federations.Responses;

namespace FreakFightsFan.Blazor.Clients
{
    public interface IFederationApiClient
    {
        Task<PagedList<FederationDto>> GetAllFederations(GetAllFederations.Query query);
        Task<FederationDto> GetFederation(int id);
        Task CreateFederation(CreateFederation.Command command);
        Task UpdateFederation(UpdateFederation.Command command);
        Task DeleteFederation(int id);
    }

    public class FederationApiClient : IFederationApiClient
    {
        private readonly IApiClient _apiClient;
        private readonly string _url = "api/federations";

        public FederationApiClient(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<PagedList<FederationDto>> GetAllFederations(GetAllFederations.Query query)
        {
            return await _apiClient.Post<GetAllFederations.Query, PagedList<FederationDto>>($"{_url}/all", query);
        }

        public async Task<FederationDto> GetFederation(int id)
        {
            return await _apiClient.Get<FederationDto>($"{_url}/{id}");
        }

        public async Task CreateFederation(CreateFederation.Command command)
        {
            await _apiClient.Post(_url, command);
        }

        public async Task UpdateFederation(UpdateFederation.Command command)
        {
            await _apiClient.Put($"{_url}/{command.Id}", command);
        }

        public async Task DeleteFederation(int id)
        {
            await _apiClient.Delete($"{_url}/{id}");
        }
    }
}
