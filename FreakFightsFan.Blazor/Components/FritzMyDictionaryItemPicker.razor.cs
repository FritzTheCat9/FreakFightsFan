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
    public partial class FritzMyDictionaryItemPicker : MudAutocomplete<MyDictionaryItemDto>
    {
        private static Func<MyDictionaryItemDto, string> DisplayDictionaryItem => item => item?.Name;

        [Parameter, EditorRequired] public string DictionaryCode { get; set; }
        [Parameter] public EventCallback<MyDictionaryItemDto> OnItemChanged { get; set; }

        [Inject] public IExceptionHandler ExceptionHandler { get; set; }
        [Inject] public IMyDictionaryItemApiClient MyDictionaryItemApiClient { get; set; }

        [Inject] public IStringLocalizer<App> Localizer { get; set; }

        private async Task OnDictionaryItemChanged(MyDictionaryItemDto value)
        {
            await SelectOption(value);
            await OnItemChanged.InvokeAsync(value);
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