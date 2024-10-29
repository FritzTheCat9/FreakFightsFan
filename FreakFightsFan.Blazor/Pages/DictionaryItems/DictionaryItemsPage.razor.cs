using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Blazor.Localization;
using FreakFightsFan.Blazor.Shared;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.DictionaryItems.Commands;
using FreakFightsFan.Shared.Features.DictionaryItems.Queries;
using FreakFightsFan.Shared.Features.DictionaryItems.Responses;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;

namespace FreakFightsFan.Blazor.Pages.DictionaryItems;

public partial class DictionaryItemsPage(
    IExceptionHandler exceptionHandler,
    IMyDictionaryItemApiClient myDictionaryItemApiClient,
    IStringLocalizer<App> localizer,
    IDialogService dialogService)
    : ComponentBase
{
    private List<BreadcrumbItem> _items;
    private PagedList<MyDictionaryItemDto> _myDictionaryItems;
    private string _searchString = "";
    private MudTable<MyDictionaryItemDto> _table;

    [Parameter] public int DictionaryId { get; set; }

    protected override void OnInitialized()
    {
        _items =
        [
            new BreadcrumbItem(localizer[nameof(AppStrings.Dictionaries)], "/dictionaries"),
            new BreadcrumbItem(localizer[nameof(AppStrings.DictionaryItems)], null, true)
        ];
    }

    private async Task<TableData<MyDictionaryItemDto>> ServerReload(TableState state, CancellationToken token)
    {
        var query = new GetAllMyDictionaryItems.Query
        {
            Page = state.Page + 1,
            PageSize = state.PageSize,
            SortColumn = state.SortLabel,
            SortOrder = (SortOrder)state.SortDirection,
            SearchTerm = _searchString,
            DictionaryId = DictionaryId
        };

        try
        {
            _myDictionaryItems = await myDictionaryItemApiClient.GetAllMyDictionaryItems(query);
        }
        catch (Exception ex)
        {
            exceptionHandler.HandleExceptions(ex);
            return new TableData<MyDictionaryItemDto> { TotalItems = 0, Items = [] };
        }

        return new TableData<MyDictionaryItemDto>
        {
            TotalItems = _myDictionaryItems.TotalCount, Items = _myDictionaryItems.Items
        };
    }

    private async Task DeleteDictionaryItem(int id)
    {
        var options = new DialogOptions { CloseOnEscapeKey = true, CloseButton = true };
        var dialog =
            await dialogService.ShowAsync<DeleteDialog>(localizer[nameof(AppStrings.Delete)], options);

        var result = await dialog.Result;
        if (result is { Canceled: false })
        {
            try
            {
                await myDictionaryItemApiClient.DeleteMyDictionaryItem(id);
                await _table.ReloadServerData();
            }
            catch (Exception ex)
            {
                exceptionHandler.HandleExceptions(ex);
            }
        }
    }

    private async Task UpdateDictionaryItem(MyDictionaryItemDto myDictionaryItemDto)
    {
        var options = new DialogOptions { CloseOnEscapeKey = true, CloseButton = true };
        var parameters = new DialogParameters<UpdateDictionaryItemDialog>
        {
            {
                x => x.Command,
                new UpdateMyDictionaryItem.Command
                {
                    Id = myDictionaryItemDto.Id, Name = myDictionaryItemDto.Name, Code = myDictionaryItemDto.Code
                }
            }
        };

        var dialog =
            await dialogService.ShowAsync<UpdateDictionaryItemDialog>(
                localizer[nameof(AppStrings.UpdateDictionaryItem)], parameters, options);
        var result = await dialog.Result;
        if (result is { Canceled: false })
        {
            await _table.ReloadServerData();
        }
    }

    private async Task CreateDictionaryItem()
    {
        var options = new DialogOptions { CloseOnEscapeKey = true, CloseButton = true };
        var parameters = new DialogParameters<CreateDictionaryItemDialog>
        {
            {
                x => x.Command, new CreateMyDictionaryItem.Command { Name = "", Code = "", DictionaryId = DictionaryId }
            }
        };

        var dialog =
            await dialogService.ShowAsync<CreateDictionaryItemDialog>(
                localizer[nameof(AppStrings.CreateDictionaryItem)], parameters, options);
        var result = await dialog.Result;
        if (result is { Canceled: false })
        {
            await _table.ReloadServerData();
        }
    }
}