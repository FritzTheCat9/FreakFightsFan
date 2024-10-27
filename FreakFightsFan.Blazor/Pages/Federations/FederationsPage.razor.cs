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

public partial class FederationsPage : ComponentBase
{
    private List<BreadcrumbItem> _items;
    private MudTable<FederationDto> _table;

    private string _searchString = "";
    private PagedList<FederationDto> _myFederations;

    [Inject] public IExceptionHandler ExceptionHandler { get; set; }
    [Inject] public IFederationApiClient FederationApiClient { get; set; }

    [Inject] public IStringLocalizer<App> Localizer { get; set; }

    [Inject] public IDialogService DialogService { get; set; }
    [Inject] public NavigationManager NavigationManager { get; set; }

    protected override void OnInitialized()
    {
        _items =
        [
            new BreadcrumbItem(Localizer[nameof(AppStrings.Federations)], href: null, disabled: true),
        ];
    }

    private async Task<TableData<FederationDto>> ServerReload(TableState state, CancellationToken token)
    {
        var query = new GetAllFederations.Query
        {
            Page = state.Page + 1,
            PageSize = state.PageSize,
            SortColumn = state.SortLabel,
            SortOrder = ((SortOrder)state.SortDirection),
            SearchTerm = _searchString,
        };

        try
        {
            _myFederations = await FederationApiClient.GetAllFederations(query);
        }
        catch (Exception ex)
        {
            ExceptionHandler.HandleExceptions(ex);
            return new TableData<FederationDto> { TotalItems = 0, Items = [] };
        }

        return new TableData<FederationDto>
        {
            TotalItems = _myFederations.TotalCount,
            Items = _myFederations.Items
        };
    }

    private void RedirectToEventsPage(int id)
    {
        NavigationManager.NavigateTo($"/events/{id}");
    }

    private async Task DeleteFederation(int id)
    {
        var options = new DialogOptions() { CloseOnEscapeKey = true, CloseButton = true };
        var dialog = await DialogService.ShowAsync<DeleteDialog>(Localizer[nameof(AppStrings.Delete)], options);

        var result = await dialog.Result;
        if (!result.Canceled)
        {
            try
            {
                await FederationApiClient.DeleteFederation(id);
                await _table.ReloadServerData();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleExceptions(ex);
            }
        }
    }

    private async Task UpdateFederation(FederationDto federationDto)
    {
        var options = new DialogOptions() { CloseOnEscapeKey = true, CloseButton = true };
        var parameters = new DialogParameters<UpdateFederationDialog>
        {
            {
                x => x.FormModel,
                new UpdateFederation.FormModel
                {
                    Id = federationDto.Id,
                    Name = federationDto.Name,
                    ImageBase64 = "",
                }
            },
            {
                x => x.Url,
                federationDto.Image?.Url
            }
        };

        var dialog = await DialogService.ShowAsync<UpdateFederationDialog>(Localizer[nameof(AppStrings.UpdateFederation)], parameters, options);
        var result = await dialog.Result;
        if (!result.Canceled)
        {
            await _table.ReloadServerData();
        }
    }

    private async Task CreateFederation()
    {
        var options = new DialogOptions() { CloseOnEscapeKey = true, CloseButton = true };
        var parameters = new DialogParameters<CreateFederationDialog>
        {
            {
                x => x.FormModel,
                new CreateFederation.FormModel()
            }
        };

        var dialog = await DialogService.ShowAsync<CreateFederationDialog>(Localizer[nameof(AppStrings.CreateFederation)], parameters, options);
        var result = await dialog.Result;
        if (!result.Canceled)
        {
            await _table.ReloadServerData();
        }
    }
}