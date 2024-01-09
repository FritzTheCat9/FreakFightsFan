using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.DictionaryItems.Commands;
using FreakFightsFan.Shared.Features.DictionaryItems.Queries;
using FreakFightsFan.Shared.Features.DictionaryItems.Responses;

namespace FreakFightsFan.Blazor.Clients
{
    public interface IMyDictionaryItemApiClient
    {
        Task<PagedList<MyDictionaryItemDto>> GetAllMyDictionaryItems(GetAllMyDictionaryItems.Query query);
        Task<PagedList<MyDictionaryItemDto>> GetAllMyDictionaryItemsByCode(GetAllMyDictionaryItemsByCode.Query query);
        Task<MyDictionaryItemDto> GetMyDictionaryItem(int id);
        Task CreateMyDictionaryItem(CreateMyDictionaryItem.Command command);
        Task UpdateMyDictionaryItem(UpdateMyDictionaryItem.Command command);
        Task DeleteMyDictionaryItem(int id);
    }

    public class MyDictionaryItemApiClient : IMyDictionaryItemApiClient
    {
        private readonly IApiClient _apiClient;
        private readonly string _url = "api/myDictionaryItems";

        public MyDictionaryItemApiClient(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<PagedList<MyDictionaryItemDto>> GetAllMyDictionaryItems(GetAllMyDictionaryItems.Query query)
        {
            return await _apiClient.Post<GetAllMyDictionaryItems.Query, PagedList<MyDictionaryItemDto>>($"{_url}/all", query);
        }

        public async Task<PagedList<MyDictionaryItemDto>> GetAllMyDictionaryItemsByCode(GetAllMyDictionaryItemsByCode.Query query)
        {
            return await _apiClient.Post<GetAllMyDictionaryItemsByCode.Query, PagedList<MyDictionaryItemDto>>($"{_url}/allByCode", query);
        }

        public async Task<MyDictionaryItemDto> GetMyDictionaryItem(int id)
        {
            return await _apiClient.Get<MyDictionaryItemDto>($"{_url}/{id}");
        }

        public async Task CreateMyDictionaryItem(CreateMyDictionaryItem.Command command)
        {
            await _apiClient.Post(_url, command);
        }

        public async Task UpdateMyDictionaryItem(UpdateMyDictionaryItem.Command command)
        {
            await _apiClient.Put($"{_url}/{command.Id}", command);
        }

        public async Task DeleteMyDictionaryItem(int id)
        {
            await _apiClient.Delete($"{_url}/{id}");
        }
    }
}
