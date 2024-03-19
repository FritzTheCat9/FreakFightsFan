using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Blazor.Localization;
using FreakFightsFan.Blazor.Shared;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.DictionaryItems.Queries;
using FreakFightsFan.Shared.Features.DictionaryItems.Responses;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;

namespace FreakFightsFan.Blazor.Pages.DictionaryItems
{
    public partial class DictionaryItemsPage : ComponentBase
    {
        private List<BreadcrumbItem> _items;
        private MudTable<MyDictionaryItemDto> _table;

        private string _searchString = "";
        private PagedList<MyDictionaryItemDto> _myDictionaryItems;

        [Parameter] public int DictionaryId { get; set; }

        [Inject] public IExceptionHandler ExceptionHandler { get; set; }
        [Inject] public IMyDictionaryItemApiClient MyDictionaryItemApiClient { get; set; }

        [Inject] public IStringLocalizer<App> Localizer { get; set; }

        [Inject] public IDialogService DialogService { get; set; }

        protected override void OnInitialized()
        {
            _items =
            [
                new(Localizer[nameof(AppStrings.Dictionaries)], href: "/dictionaries"),
                new(Localizer[nameof(AppStrings.DictionaryItems)], href: null, disabled: true),
            ];
        }

        private async Task<TableData<MyDictionaryItemDto>> ServerReload(TableState state)
        {
            var query = new GetAllMyDictionaryItems.Query
            {
                Page = state.Page + 1,
                PageSize = state.PageSize,
                SortColumn = state.SortLabel,
                SortOrder = ((SortOrder)state.SortDirection),
                SearchTerm = _searchString,
                DictionaryId = DictionaryId,
            };

            try
            {
                _myDictionaryItems = await MyDictionaryItemApiClient.GetAllMyDictionaryItems(query);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleExceptions(ex);
                return new() { TotalItems = 0, Items = [] };
            }

            return new()
            {
                TotalItems = _myDictionaryItems.TotalCount,
                Items = _myDictionaryItems.Items
            };
        }

        private async Task DeleteDictionaryItem(int id)
        {
            var options = new DialogOptions() { CloseOnEscapeKey = true, CloseButton = true };
            var dialog = await DialogService.ShowAsync<DeleteDialog>(Localizer[nameof(AppStrings.Delete)], options);

            var result = await dialog.Result;
            if (!result.Canceled)
            {
                try
                {
                    await MyDictionaryItemApiClient.DeleteMyDictionaryItem(id);
                    await _table.ReloadServerData();
                }
                catch (Exception ex)
                {
                    ExceptionHandler.HandleExceptions(ex);
                }
            }
        }

        private async Task UpdateDictionaryItem(MyDictionaryItemDto myDictionaryItemDto)
        {
            var options = new DialogOptions() { CloseOnEscapeKey = true, CloseButton = true };
            var parameters = new DialogParameters<UpdateDictionaryItemDialog>
            {
                {
                    x => x.Command,
                    new()
                    {
                        Id = myDictionaryItemDto.Id,
                        Name = myDictionaryItemDto.Name,
                        Code = myDictionaryItemDto.Code,
                    }
                }
            };

            var dialog = await DialogService.ShowAsync<UpdateDictionaryItemDialog>(Localizer[nameof(AppStrings.UpdateDictionaryItem)], parameters, options);
            var result = await dialog.Result;
            if (!result.Canceled)
                await _table.ReloadServerData();
        }

        private async Task CreateDictionaryItem()
        {
            var options = new DialogOptions() { CloseOnEscapeKey = true, CloseButton = true };
            var parameters = new DialogParameters<CreateDictionaryItemDialog>
            {
                {
                    x => x.Command,
                    new()
                    {
                        Name = "",
                        Code = "",
                        DictionaryId = DictionaryId,
                    }
                }
            };

            var dialog = await DialogService.ShowAsync<CreateDictionaryItemDialog>(Localizer[nameof(AppStrings.CreateDictionaryItem)], parameters, options);
            var result = await dialog.Result;
            if (!result.Canceled)
                await _table.ReloadServerData();
        }
    }
}