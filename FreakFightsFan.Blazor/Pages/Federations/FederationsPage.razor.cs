using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Blazor.Localization;
using FreakFightsFan.Blazor.Shared;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Federations.Commands;
using FreakFightsFan.Shared.Features.Federations.Queries;
using FreakFightsFan.Shared.Features.Federations.Responses;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;

namespace FreakFightsFan.Blazor.Pages.Federations;

public partial class FederationsPage(
    IExceptionHandler exceptionHandler,
    IFederationApiClient federationApiClient,
    IStringLocalizer<App> localizer,
    IDialogService dialogService,
    NavigationManager navigationManager)
    : ComponentBase
{
    private List<BreadcrumbItem> _items;
    private PagedList<FederationDto> _myFederations;
    private string _searchString = "";
    private MudTable<FederationDto> _table;

    protected override void OnInitialized()
    {
        _items =
        [
            new BreadcrumbItem(localizer[nameof(AppStrings.Federations)], null, true)
        ];
    }

    private async Task<TableData<FederationDto>> ServerReload(TableState state, CancellationToken token)
    {
        var query = new GetAllFederations.Query
        {
            Page = state.Page + 1,
            PageSize = state.PageSize,
            SortColumn = state.SortLabel,
            SortOrder = (SortOrder)state.SortDirection,
            SearchTerm = _searchString
        };

        try
        {
            _myFederations = await federationApiClient.GetAllFederations(query);
        }
        catch (Exception ex)
        {
            exceptionHandler.HandleExceptions(ex);
            return new TableData<FederationDto> { TotalItems = 0, Items = [] };
        }

        return new TableData<FederationDto> { TotalItems = _myFederations.TotalCount, Items = _myFederations.Items };
    }

    private void RedirectToEventsPage(int id)
    {
        navigationManager.NavigateTo($"/events/{id}");
    }

    private async Task DeleteFederation(int id)
    {
        var options = new DialogOptions { CloseOnEscapeKey = true, CloseButton = true };
        var dialog =
            await dialogService.ShowAsync<DeleteDialog>(localizer[nameof(AppStrings.Delete)], options);

        var result = await dialog.Result;
        if (result is { Canceled: false })
        {
            try
            {
                await federationApiClient.DeleteFederation(id);
                await _table.ReloadServerData();
            }
            catch (Exception ex)
            {
                exceptionHandler.HandleExceptions(ex);
            }
        }
    }

    private async Task UpdateFederation(FederationDto federationDto)
    {
        var options = new DialogOptions { CloseOnEscapeKey = true, CloseButton = true };
        var parameters = new DialogParameters<UpdateFederationDialog>
        {
            {
                x => x.FormModel,
                new UpdateFederation.FormModel { Id = federationDto.Id, Name = federationDto.Name, ImageBase64 = "" }
            },
            { x => x.Url, federationDto.Image?.Url }
        };

        var dialog =
            await dialogService.ShowAsync<UpdateFederationDialog>(localizer[nameof(AppStrings.UpdateFederation)],
                parameters, options);
        var result = await dialog.Result;
        if (result is { Canceled: false })
        {
            await _table.ReloadServerData();
        }
    }

    private async Task CreateFederation()
    {
        var options = new DialogOptions { CloseOnEscapeKey = true, CloseButton = true };
        var parameters = new DialogParameters<CreateFederationDialog>
        {
            { x => x.FormModel, new CreateFederation.FormModel() }
        };

        var dialog =
            await dialogService.ShowAsync<CreateFederationDialog>(localizer[nameof(AppStrings.CreateFederation)],
                parameters, options);
        var result = await dialog.Result;
        if (result is { Canceled: false })
        {
            await _table.ReloadServerData();
        }
    }
}