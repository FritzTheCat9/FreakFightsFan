using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Dictionaries.Requests;
using FreakFightsFan.Shared.Features.Dictionaries.Responses;

namespace FreakFightsFan.Blazor.Clients
{
    public interface IMyDictionaryApiClient
    {
        Task<PagedList<MyDictionaryDto>> GetAllMyDictionaries(GetAllMyDictionariesRequest getAllMyDictionariesRequest);
        Task<MyDictionaryDto> GetMyDictionary(int id);
        Task CreateMyDictionary(CreateMyDictionaryRequest createMyDictionaryRequest);
        Task UpdateMyDictionary(UpdateMyDictionaryRequest updateMyDictionaryRequest);
        Task DeleteMyDictionary(int id);
    }

    public class MyDictionaryApiClient : IMyDictionaryApiClient
    {
        private readonly IApiClient _apiClient;
        private readonly string _url = "api/myDictionaries";

        public MyDictionaryApiClient(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<PagedList<MyDictionaryDto>> GetAllMyDictionaries(GetAllMyDictionariesRequest getAllMyDictionariesRequest)
        {
            return await _apiClient.Post<GetAllMyDictionariesRequest, PagedList<MyDictionaryDto>>(_url + "/all", getAllMyDictionariesRequest);
        }

        public async Task<MyDictionaryDto> GetMyDictionary(int id)
        {
            return await _apiClient.Get<MyDictionaryDto>(_url + id);
        }

        public async Task CreateMyDictionary(CreateMyDictionaryRequest createMyDictionaryRequest)
        {
            await _apiClient.Post(_url, createMyDictionaryRequest);
        }

        public async Task UpdateMyDictionary(UpdateMyDictionaryRequest updateMyDictionaryRequest)
        {
            await _apiClient.Put(_url + "/" + updateMyDictionaryRequest.Id, updateMyDictionaryRequest);
        }

        public async Task DeleteMyDictionary(int id)
        {
            await _apiClient.Delete(_url + "/" + id);
        }
    }
}
