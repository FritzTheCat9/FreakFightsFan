using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Dictionaries.Commands;
using FreakFightsFan.Shared.Features.Dictionaries.Queries;
using FreakFightsFan.Shared.Features.Dictionaries.Responses;

namespace FreakFightsFan.Blazor.Clients
{
    public interface IMyDictionaryApiClient
    {
        Task<PagedList<MyDictionaryDto>> GetAllMyDictionaries(GetAllMyDictionaries.Query query);
        Task<MyDictionaryDto> GetMyDictionary(int id);
        Task CreateMyDictionary(CreateMyDictionary.Command command);
        Task UpdateMyDictionary(UpdateMyDictionary.Command command);
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

        public async Task<PagedList<MyDictionaryDto>> GetAllMyDictionaries(GetAllMyDictionaries.Query query)
        {
            return await _apiClient.Post<GetAllMyDictionaries.Query, PagedList<MyDictionaryDto>>($"{_url}/all", query);
        }

        public async Task<MyDictionaryDto> GetMyDictionary(int id)
        {
            return await _apiClient.Get<MyDictionaryDto>($"{_url}/{id}");
        }

        public async Task CreateMyDictionary(CreateMyDictionary.Command command)
        {
            await _apiClient.Post(_url, command);
        }

        public async Task UpdateMyDictionary(UpdateMyDictionary.Command command)
        {
            await _apiClient.Put($"{_url}/{command.Id}", command);
        }

        public async Task DeleteMyDictionary(int id)
        {
            await _apiClient.Delete($"{_url}/{id}");
        }
    }
}
