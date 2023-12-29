using FreakFightsFan.Blazor.Pages.Error;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Dictionaries.Helpers;
using FreakFightsFan.Shared.Features.DictionaryItems.Requests;
using FreakFightsFan.Shared.Features.DictionaryItems.Responses;

namespace FreakFightsFan.Blazor.Clients
{
    public interface IMyDictionaryItemClientHelper
    {
        Func<MyDictionaryItemDto, string> DisplayDictionaryItem { get; }
        Task<IEnumerable<MyDictionaryItemDto>> SearchCity(string value, CancellationToken token);
        Task<IEnumerable<MyDictionaryItemDto>> SearchHall(string value, CancellationToken token);
        Task<IEnumerable<MyDictionaryItemDto>> SearchFightType(string value, CancellationToken token);
    }

    public class MyDictionaryItemClientHelper : IMyDictionaryItemClientHelper
    {
        private readonly IMyDictionaryItemApiClient _myDictionaryItemApiClient;
        private readonly IExceptionHandler _exceptionHandler;

        public MyDictionaryItemClientHelper(IMyDictionaryItemApiClient myDictionaryItemApiClient, IExceptionHandler exceptionHandler)
        {
            _myDictionaryItemApiClient = myDictionaryItemApiClient;
            _exceptionHandler = exceptionHandler;
        }

        public Func<MyDictionaryItemDto, string> DisplayDictionaryItem 
        {
            get => 
                item => item is null ? null : item.Name;
        }

        public async Task<IEnumerable<MyDictionaryItemDto>> SearchCity(string value, CancellationToken token)
        {
            return await ReturnMyDictionaryItems(value, DictionaryCode.City);
        }

        public async Task<IEnumerable<MyDictionaryItemDto>> SearchHall(string value, CancellationToken token)
        {
            return await ReturnMyDictionaryItems(value, DictionaryCode.Hall);
        }

        public async Task<IEnumerable<MyDictionaryItemDto>> SearchFightType(string value, CancellationToken token)
        {
            return await ReturnMyDictionaryItems(value, DictionaryCode.FightType);
        }

        private async Task<IEnumerable<MyDictionaryItemDto>> ReturnMyDictionaryItems(string value, string dictionaryCode)
        {
            PagedList<MyDictionaryItemDto> DictionaryItemsPagedList = null;

            var getAllMyDictionaryItemsByCodeRequest = new GetAllMyDictionaryItemsByCodeRequest
            {
                Page = 1,
                PageSize = 10,
                SortColumn = "name",
                SortOrder = SortOrder.Ascending,
                SearchTerm = value ?? "",
                DictionaryCode = dictionaryCode
            };

            try
            {
                DictionaryItemsPagedList = await _myDictionaryItemApiClient.GetAllMyDictionaryItemsByCode(getAllMyDictionaryItemsByCodeRequest);
            }
            catch (Exception ex)
            {
                _exceptionHandler.HandleExceptions(ex);
                return new List<MyDictionaryItemDto>();
            }

            return DictionaryItemsPagedList.Items;
        }
    }
}
