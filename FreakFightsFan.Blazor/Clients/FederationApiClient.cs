using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Federations.Requests;
using FreakFightsFan.Shared.Features.Federations.Responses;

namespace FreakFightsFan.Blazor.Clients
{
    public interface IFederationApiClient
    {
        Task<PagedList<FederationDto>> GetAllFederations(GetAllFederationsRequest request);
        Task<FederationDto> GetFederation(int id);
        Task CreateFederation(CreateFederationRequest request);
        Task UpdateFederation(UpdateFederationRequest request);
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

        public async Task<PagedList<FederationDto>> GetAllFederations(GetAllFederationsRequest request)
        {
            return await _apiClient.Post<GetAllFederationsRequest, PagedList<FederationDto>>(_url + "/all", request);
        }

        public async Task<FederationDto> GetFederation(int id)
        {
            return await _apiClient.Get<FederationDto>(_url + id);
        }

        public async Task CreateFederation(CreateFederationRequest request)
        {
            await _apiClient.Post(_url, request);
        }

        public async Task UpdateFederation(UpdateFederationRequest request)
        {
            await _apiClient.Put(_url + "/" + request.Id, request);
        }

        public async Task DeleteFederation(int id)
        {
            await _apiClient.Delete(_url + "/" + id);
        }
    }
}
