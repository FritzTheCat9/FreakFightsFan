using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.DictionaryItems.Queries;
using FreakFightsFan.Shared.Features.DictionaryItems.Responses;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;

namespace FreakFightsFan.Blazor.Components
{
    public partial class FritzDictionaryItemPicker : MudNumericField<int?>
    {
        private static Func<MyDictionaryItemDto, string> DisplayDictionaryItem 
            => item => item?.Name;

        [Parameter, EditorRequired] public string DictionaryCode { get; set; }
        [Parameter] public MyDictionaryItemDto DictionaryItemDto { get; set; }
        [Parameter] public EventCallback<MyDictionaryItemDto> OnDictionaryItemDtoChanged { get; set; }

        [Inject] public IExceptionHandler ExceptionHandler { get; set; }
        [Inject] public IMyDictionaryItemApiClient MyDictionaryItemApiClient { get; set; }

        [Inject] public IStringLocalizer<App> Localizer { get; set; }

        private async Task OnValueChanged(int? value) 
            => await SetValueAsync(value);

        private async Task OnDictionaryItemChanged(MyDictionaryItemDto value)
        {
            await OnDictionaryItemDtoChanged.InvokeAsync(value);
            await OnValueChanged(value?.Id);
        }

        private async Task<IEnumerable<MyDictionaryItemDto>> Search(string value, CancellationToken token) 
            => await ReturnMyDictionaryItems(value, DictionaryCode);

        private async Task<IEnumerable<MyDictionaryItemDto>> ReturnMyDictionaryItems(string value, string dictionaryCode)
        {
            PagedList<MyDictionaryItemDto> DictionaryItemsPagedList;

            var query = new GetAllMyDictionaryItemsByCode.Query
            {
                Page = 1,
                PageSize = 10,
                SortColumn = "name",
                SortOrder = SortOrder.Ascending,
                SearchTerm = value ?? "",
                DictionaryCode = dictionaryCode,
            };

            try
            {
                DictionaryItemsPagedList = await MyDictionaryItemApiClient.GetAllMyDictionaryItemsByCode(query);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleExceptions(ex);
                return [];
            }

            return DictionaryItemsPagedList.Items;
        }
    }
}