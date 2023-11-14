using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Dictionaries.Requests;
using FreakFightsFan.Shared.Features.Dictionaries.Responses;

namespace FreakFightsFan.Blazor.Services
{
    public interface IMyDictionaryHttpService
    {
        Task<PagedList<MyDictionaryDto>> GetAllMyDictionaries(GetAllMyDictionariesRequest getAllMyDictionariesRequest);
        Task<MyDictionaryDto> GetMyDictionary(int id);
        Task CreateMyDictionary(CreateMyDictionaryRequest createMyDictionaryRequest);
        Task UpdateMyDictionary(UpdateMyDictionaryRequest updateMyDictionaryRequest);
        Task DeleteMyDictionary(int id);
    }

    public class MyDictionaryHttpService : IMyDictionaryHttpService
    {
        private readonly IHttpService _httpService;
        private readonly string _url = "api/myDictionaries";

        public MyDictionaryHttpService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<PagedList<MyDictionaryDto>> GetAllMyDictionaries(GetAllMyDictionariesRequest getAllMyDictionariesRequest)
        {
            return await _httpService.Post<GetAllMyDictionariesRequest, PagedList<MyDictionaryDto>>(_url + "/all", getAllMyDictionariesRequest);
        }

        public async Task<MyDictionaryDto> GetMyDictionary(int id)
        {
            return await _httpService.Get<MyDictionaryDto>(_url + id);
        }

        public async Task CreateMyDictionary(CreateMyDictionaryRequest createMyDictionaryRequest)
        {
            await _httpService.Post(_url, createMyDictionaryRequest);
        }

        public async Task UpdateMyDictionary(UpdateMyDictionaryRequest updateMyDictionaryRequest)
        {
            await _httpService.Put(_url + "/" + updateMyDictionaryRequest.Id, updateMyDictionaryRequest);
        }

        public async Task DeleteMyDictionary(int id)
        {
            await _httpService.Delete(_url + "/" + id);
        }
    }
}
