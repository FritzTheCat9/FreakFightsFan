using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.DictionaryItems.Requests;
using FreakFightsFan.Shared.Features.DictionaryItems.Responses;

namespace FreakFightsFan.Blazor.Clients
{
    public interface IMyDictionaryItemApiClient
    {
        Task<PagedList<MyDictionaryItemDto>> GetAllMyDictionaryItems(GetAllMyDictionaryItemsRequest request);
        Task<PagedList<MyDictionaryItemDto>> GetAllMyDictionaryItemsByCode(GetAllMyDictionaryItemsByCodeRequest request);
        Task<MyDictionaryItemDto> GetMyDictionaryItem(int id);
        Task CreateMyDictionaryItem(CreateMyDictionaryItemRequest request);
        Task UpdateMyDictionaryItem(UpdateMyDictionaryItemRequest request);
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

        public async Task<PagedList<MyDictionaryItemDto>> GetAllMyDictionaryItems(GetAllMyDictionaryItemsRequest request)
        {
            return await _apiClient.Post<GetAllMyDictionaryItemsRequest, PagedList<MyDictionaryItemDto>>(_url + "/all", request);
        }

        public async Task<PagedList<MyDictionaryItemDto>> GetAllMyDictionaryItemsByCode(GetAllMyDictionaryItemsByCodeRequest request)
        {
            return await _apiClient.Post<GetAllMyDictionaryItemsByCodeRequest, PagedList<MyDictionaryItemDto>>(_url + "/allByCode", request);
        }

        public async Task<MyDictionaryItemDto> GetMyDictionaryItem(int id)
        {
            return await _apiClient.Get<MyDictionaryItemDto>(_url + "/" + id);
        }

        public async Task CreateMyDictionaryItem(CreateMyDictionaryItemRequest request)
        {
            await _apiClient.Post(_url, request);
        }

        public async Task UpdateMyDictionaryItem(UpdateMyDictionaryItemRequest request)
        {
            await _apiClient.Put(_url + "/" + request.Id, request);
        }

        public async Task DeleteMyDictionaryItem(int id)
        {
            await _apiClient.Delete(_url + "/" + id);
        }
    }
}
