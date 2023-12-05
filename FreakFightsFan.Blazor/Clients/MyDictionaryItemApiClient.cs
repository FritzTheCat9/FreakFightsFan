using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.DictionaryItems.Requests;
using FreakFightsFan.Shared.Features.DictionaryItems.Responses;

namespace FreakFightsFan.Blazor.Clients
{
    public interface IMyDictionaryItemApiClient
    {
        Task<PagedList<MyDictionaryItemDto>> GetAllMyDictionaryItems(GetAllMyDictionaryItemsRequest getAllMyDictionaryItemsRequest);
        Task<PagedList<MyDictionaryItemDto>> GetAllMyDictionaryItemsByCode(GetAllMyDictionaryItemsByCodeRequest getAllMyDictionaryItemsByCodeRequest);
        Task<MyDictionaryItemDto> GetMyDictionaryItem(int id);
        Task CreateMyDictionaryItem(CreateMyDictionaryItemRequest createMyDictionaryItemRequest);
        Task UpdateMyDictionaryItem(UpdateMyDictionaryItemRequest updateMyDictionaryItemRequest);
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

        public async Task<PagedList<MyDictionaryItemDto>> GetAllMyDictionaryItems(GetAllMyDictionaryItemsRequest getAllMyDictionaryItemsRequest)
        {
            return await _apiClient.Post<GetAllMyDictionaryItemsRequest, PagedList<MyDictionaryItemDto>>(_url + "/all", getAllMyDictionaryItemsRequest);
        }

        public async Task<PagedList<MyDictionaryItemDto>> GetAllMyDictionaryItemsByCode(GetAllMyDictionaryItemsByCodeRequest getAllMyDictionaryItemsByCodeRequest)
        {
            return await _apiClient.Post<GetAllMyDictionaryItemsByCodeRequest, PagedList<MyDictionaryItemDto>>(_url + "/allByCode", getAllMyDictionaryItemsByCodeRequest);
        }

        public async Task<MyDictionaryItemDto> GetMyDictionaryItem(int id)
        {
            return await _apiClient.Get<MyDictionaryItemDto>(_url + id);
        }

        public async Task CreateMyDictionaryItem(CreateMyDictionaryItemRequest createMyDictionaryItemRequest)
        {
            await _apiClient.Post(_url, createMyDictionaryItemRequest);
        }

        public async Task UpdateMyDictionaryItem(UpdateMyDictionaryItemRequest updateMyDictionaryItemRequest)
        {
            await _apiClient.Put(_url + "/" + updateMyDictionaryItemRequest.Id, updateMyDictionaryItemRequest);
        }

        public async Task DeleteMyDictionaryItem(int id)
        {
            await _apiClient.Delete(_url + "/" + id);
        }
    }
}
