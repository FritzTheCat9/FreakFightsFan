using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Blazor.Localization;
using FreakFightsFan.Blazor.Shared;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Dictionaries.Commands;
using FreakFightsFan.Shared.Features.Dictionaries.Queries;
using FreakFightsFan.Shared.Features.Dictionaries.Responses;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;

namespace FreakFightsFan.Blazor.Pages.Dictionaries;

public partial class DictionariesPage(
    IExceptionHandler exceptionHandler,
    IMyDictionaryApiClient myDictionaryApiClient,
    IStringLocalizer<App> localizer,
    IDialogService dialogService,
    NavigationManager navigationManager)
    : ComponentBase
{
    private List<BreadcrumbItem> _items;
    private PagedList<MyDictionaryDto> _myDictionaries;
    private string _searchString = "";
    private MudTable<MyDictionaryDto> _table;

    protected override void OnInitialized()
    {
        _items =
        [
            new BreadcrumbItem(localizer[nameof(AppStrings.Dictionaries)], null, true)
        ];
    }

    private async Task<TableData<MyDictionaryDto>> ServerReload(TableState state, CancellationToken token)
    {
        var query = new GetAllMyDictionaries.Query
        {
            Page = state.Page + 1,
            PageSize = state.PageSize,
            SortColumn = state.SortLabel,
            SortOrder = (SortOrder)state.SortDirection,
            SearchTerm = _searchString
        };

        try
        {
            _myDictionaries = await myDictionaryApiClient.GetAllMyDictionaries(query);
        }
        catch (Exception ex)
        {
            exceptionHandler.HandleExceptions(ex);
            return new TableData<MyDictionaryDto> { TotalItems = 0, Items = [] };
        }

        return new TableData<MyDictionaryDto>
        {
            TotalItems = _myDictionaries.TotalCount, Items = _myDictionaries.Items
        };
    }

    private void RedirectToDictionaryItemsPage(int id)
    {
        navigationManager.NavigateTo($"/dictionary/{id}");
    }

    private async Task DeleteDictionary(int id)
    {
        var options = new DialogOptions { CloseOnEscapeKey = true, CloseButton = true };
        var dialog =
            await dialogService.ShowAsync<DeleteDialog>(localizer[nameof(AppStrings.Delete)], options);

        var result = await dialog.Result;
        if (result is { Canceled: false })
        {
            try
            {
                await myDictionaryApiClient.DeleteMyDictionary(id);
                await _table.ReloadServerData();
            }
            catch (Exception ex)
            {
                exceptionHandler.HandleExceptions(ex);
            }
        }
    }

    private async Task UpdateDictionary(MyDictionaryDto myDictionaryDto)
    {
        var options = new DialogOptions { CloseOnEscapeKey = true, CloseButton = true };
        var parameters = new DialogParameters<UpdateDictionaryDialog>
        {
            {
                x => x.Command,
                new UpdateMyDictionary.Command
                {
                    Id = myDictionaryDto.Id, Name = myDictionaryDto.Name, Code = myDictionaryDto.Code
                }
            }
        };

        var dialog =
            await dialogService.ShowAsync<UpdateDictionaryDialog>(localizer[nameof(AppStrings.UpdateDictionary)],
                parameters, options);
        var result = await dialog.Result;
        if (result is { Canceled: false })
        {
            await _table.ReloadServerData();
        }
    }

    private async Task CreateDictionary()
    {
        var options = new DialogOptions { CloseOnEscapeKey = true, CloseButton = true };
        var parameters = new DialogParameters<CreateDictionaryDialog>
        {
            { x => x.Command, new CreateMyDictionary.Command() }
        };

        var dialog =
            await dialogService.ShowAsync<CreateDictionaryDialog>(localizer[nameof(AppStrings.CreateDictionary)],
                parameters, options);
        var result = await dialog.Result;
        if (result is { Canceled: false })
        {
            await _table.ReloadServerData();
        }
    }
}