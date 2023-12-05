using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Federations.Requests;
using FreakFightsFan.Shared.Features.Federations.Responses;

namespace FreakFightsFan.Blazor.Clients
{
    public interface IFederationApiClient
    {
        Task<PagedList<FederationDto>> GetAllFederations(GetAllFederationsRequest getAllFederationsRequest);
        Task<FederationDto> GetFederation(int id);
        Task CreateFederation(CreateFederationRequest createFederationRequest);
        Task UpdateFederation(UpdateFederationRequest updateFederationRequest);
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

        public async Task<PagedList<FederationDto>> GetAllFederations(GetAllFederationsRequest getAllFederationsRequest)
        {
            return await _apiClient.Post<GetAllFederationsRequest, PagedList<FederationDto>>(_url + "/all", getAllFederationsRequest);
        }

        public async Task<FederationDto> GetFederation(int id)
        {
            return await _apiClient.Get<FederationDto>(_url + id);
        }

        public async Task CreateFederation(CreateFederationRequest createFederationRequest)
        {
            await _apiClient.Post(_url, createFederationRequest);
        }

        public async Task UpdateFederation(UpdateFederationRequest updateFederationRequest)
        {
            await _apiClient.Put(_url + "/" + updateFederationRequest.Id, updateFederationRequest);
        }

        public async Task DeleteFederation(int id)
        {
            await _apiClient.Delete(_url + "/" + id);
        }
    }
}
