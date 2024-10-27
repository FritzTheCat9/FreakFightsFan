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

public partial class DictionariesPage : ComponentBase
{
    private List<BreadcrumbItem> _items;
    private MudTable<MyDictionaryDto> _table;

    private string _searchString = "";
    private PagedList<MyDictionaryDto> _myDictionaries;

    [Inject] public IExceptionHandler ExceptionHandler { get; set; }
    [Inject] public IMyDictionaryApiClient MyDictionaryApiClient { get; set; }

    [Inject] public IStringLocalizer<App> Localizer { get; set; }

    [Inject] public IDialogService DialogService { get; set; }
    [Inject] public NavigationManager NavigationManager { get; set; }

    protected override void OnInitialized()
    {
        _items =
        [
            new BreadcrumbItem(Localizer[nameof(AppStrings.Dictionaries)], href: null, disabled: true),
        ];
    }

    private async Task<TableData<MyDictionaryDto>> ServerReload(TableState state, CancellationToken token)
    {
        var query = new GetAllMyDictionaries.Query
        {
            Page = state.Page + 1,
            PageSize = state.PageSize,
            SortColumn = state.SortLabel,
            SortOrder = ((SortOrder)state.SortDirection),
            SearchTerm = _searchString,
        };

        try
        {
            _myDictionaries = await MyDictionaryApiClient.GetAllMyDictionaries(query);
        }
        catch (Exception ex)
        {
            ExceptionHandler.HandleExceptions(ex);
            return new TableData<MyDictionaryDto> { TotalItems = 0, Items = [] };
        }

        return new TableData<MyDictionaryDto>
        {
            TotalItems = _myDictionaries.TotalCount,
            Items = _myDictionaries.Items
        };
    }

    private void RedirectToDictionaryItemsPage(int id)
    {
        NavigationManager.NavigateTo($"/dictionary/{id}");
    }

    private async Task DeleteDictionary(int id)
    {
        var options = new DialogOptions() { CloseOnEscapeKey = true, CloseButton = true };
        var dialog = await DialogService.ShowAsync<DeleteDialog>(Localizer[nameof(AppStrings.Delete)], options);

        var result = await dialog.Result;
        if (!result.Canceled)
        {
            try
            {
                await MyDictionaryApiClient.DeleteMyDictionary(id);
                await _table.ReloadServerData();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleExceptions(ex);
            }
        }
    }

    private async Task UpdateDictionary(MyDictionaryDto myDictionaryDto)
    {
        var options = new DialogOptions() { CloseOnEscapeKey = true, CloseButton = true };
        var parameters = new DialogParameters<UpdateDictionaryDialog>
        {
            {
                x => x.Command,
                new UpdateMyDictionary.Command
                {
                    Id = myDictionaryDto.Id,
                    Name = myDictionaryDto.Name,
                    Code = myDictionaryDto.Code
                }
            }
        };

        var dialog = await DialogService.ShowAsync<UpdateDictionaryDialog>(Localizer[nameof(AppStrings.UpdateDictionary)], parameters, options);
        var result = await dialog.Result;
        if (!result.Canceled)
        {
            await _table.ReloadServerData();
        }
    }

    private async Task CreateDictionary()
    {
        var options = new DialogOptions() { CloseOnEscapeKey = true, CloseButton = true };
        var parameters = new DialogParameters<CreateDictionaryDialog>
        {
            {
                x => x.Command,
                new CreateMyDictionary.Command()
            }
        };

        var dialog = await DialogService.ShowAsync<CreateDictionaryDialog>(Localizer[nameof(AppStrings.CreateDictionary)], parameters, options);
        var result = await dialog.Result;
        if (!result.Canceled)
        {
            await _table.ReloadServerData();
        }
    }
}