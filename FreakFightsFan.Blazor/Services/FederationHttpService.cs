using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Federations.Requests;
using FreakFightsFan.Shared.Features.Federations.Responses;

namespace FreakFightsFan.Blazor.Services
{
    public interface IFederationHttpService
    {
        Task<PagedList<FederationDto>> GetAllFederations(GetAllFederationsRequest getAllFederationsRequest);
        Task<FederationDto> GetFederation(int id);
        Task CreateFederation(CreateFederationRequest createFederationRequest);
        Task UpdateFederation(UpdateFederationRequest updateFederationRequest);
        Task DeleteFederation(int id);
    }

    public class FederationHttpService : IFederationHttpService
    {
        private readonly IHttpService _httpService;
        private readonly string _url = "api/federations";

        public FederationHttpService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<PagedList<FederationDto>> GetAllFederations(GetAllFederationsRequest getAllFederationsRequest)
        {
            return await _httpService.Post<GetAllFederationsRequest, PagedList<FederationDto>>(_url + "/all", getAllFederationsRequest);
        }

        public async Task<FederationDto> GetFederation(int id)
        {
            return await _httpService.Get<FederationDto>(_url + id);
        }

        public async Task CreateFederation(CreateFederationRequest createFederationRequest)
        {
            await _httpService.Post(_url, createFederationRequest);
        }

        public async Task UpdateFederation(UpdateFederationRequest updateFederationRequest)
        {
            await _httpService.Put(_url + "/" + updateFederationRequest.Id, updateFederationRequest);
        }

        public async Task DeleteFederation(int id)
        {
            await _httpService.Delete(_url + "/" + id);
        }
    }
}
