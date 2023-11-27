using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.DictionaryItems.Requests;
using FreakFightsFan.Shared.Features.DictionaryItems.Responses;

namespace FreakFightsFan.Blazor.Services
{
    public interface IMyDictionaryItemHttpService
    {
        Task<PagedList<MyDictionaryItemDto>> GetAllMyDictionaryItems(GetAllMyDictionaryItemsRequest getAllMyDictionaryItemsRequest);
        Task<PagedList<MyDictionaryItemDto>> GetAllMyDictionaryItemsByCode(GetAllMyDictionaryItemsByCodeRequest getAllMyDictionaryItemsByCodeRequest);
        Task<MyDictionaryItemDto> GetMyDictionaryItem(int id);
        Task CreateMyDictionaryItem(CreateMyDictionaryItemRequest createMyDictionaryItemRequest);
        Task UpdateMyDictionaryItem(UpdateMyDictionaryItemRequest updateMyDictionaryItemRequest);
        Task DeleteMyDictionaryItem(int id);
    }

    public class MyDictionaryItemHttpService : IMyDictionaryItemHttpService
    {
        private readonly IHttpService _httpService;
        private readonly string _url = "api/myDictionaryItems";

        public MyDictionaryItemHttpService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<PagedList<MyDictionaryItemDto>> GetAllMyDictionaryItems(GetAllMyDictionaryItemsRequest getAllMyDictionaryItemsRequest)
        {
            return await _httpService.Post<GetAllMyDictionaryItemsRequest, PagedList<MyDictionaryItemDto>>(_url + "/all", getAllMyDictionaryItemsRequest);
        }

        public async Task<PagedList<MyDictionaryItemDto>> GetAllMyDictionaryItemsByCode(GetAllMyDictionaryItemsByCodeRequest getAllMyDictionaryItemsByCodeRequest)
        {
            return await _httpService.Post<GetAllMyDictionaryItemsByCodeRequest, PagedList<MyDictionaryItemDto>>(_url + "/allByCode", getAllMyDictionaryItemsByCodeRequest);
        }

        public async Task<MyDictionaryItemDto> GetMyDictionaryItem(int id)
        {
            return await _httpService.Get<MyDictionaryItemDto>(_url + id);
        }

        public async Task CreateMyDictionaryItem(CreateMyDictionaryItemRequest createMyDictionaryItemRequest)
        {
            await _httpService.Post(_url, createMyDictionaryItemRequest);
        }

        public async Task UpdateMyDictionaryItem(UpdateMyDictionaryItemRequest updateMyDictionaryItemRequest)
        {
            await _httpService.Put(_url + "/" + updateMyDictionaryItemRequest.Id, updateMyDictionaryItemRequest);
        }

        public async Task DeleteMyDictionaryItem(int id)
        {
            await _httpService.Delete(_url + "/" + id);
        }
    }
}
