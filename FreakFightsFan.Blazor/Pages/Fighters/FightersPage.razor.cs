using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Blazor.Localization;
using FreakFightsFan.Blazor.Shared;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Fighters.Commands;
using FreakFightsFan.Shared.Features.Fighters.Queries;
using FreakFightsFan.Shared.Features.Fighters.Responses;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;

namespace FreakFightsFan.Blazor.Pages.Fighters;

public partial class FightersPage(
    IExceptionHandler exceptionHandler,
    IFighterApiClient fighterApiClient,
    IStringLocalizer<App> localizer,
    IDialogService dialogService,
    NavigationManager navigationManager)
    : ComponentBase
{
    private List<BreadcrumbItem> _items;
    private PagedList<FighterDto> _myFighters;
    private string _searchString = "";
    private MudTable<FighterDto> _table;

    protected override void OnInitialized()
    {
        _items =
        [
            new BreadcrumbItem(localizer[nameof(AppStrings.Fighters)], null, true)
        ];
    }

    private async Task<TableData<FighterDto>> ServerReload(TableState state, CancellationToken token)
    {
        var query = new GetAllFighters.Query
        {
            Page = state.Page + 1,
            PageSize = state.PageSize,
            SortColumn = state.SortLabel,
            SortOrder = (SortOrder)state.SortDirection,
            SearchTerm = _searchString
        };

        try
        {
            _myFighters = await fighterApiClient.GetAllFighters(query);
        }
        catch (Exception ex)
        {
            exceptionHandler.HandleExceptions(ex);
            return new TableData<FighterDto> { TotalItems = 0, Items = [] };
        }

        return new TableData<FighterDto> { TotalItems = _myFighters.TotalCount, Items = _myFighters.Items };
    }

    private async Task DeleteFighter(int id)
    {
        var options = new DialogOptions { CloseOnEscapeKey = true, CloseButton = true };
        var dialog =
            await dialogService.ShowAsync<DeleteDialog>(localizer[nameof(AppStrings.Delete)], options);

        var result = await dialog.Result;
        if (result is { Canceled: false })
        {
            try
            {
                await fighterApiClient.DeleteFighter(id);
                await _table.ReloadServerData();
            }
            catch (Exception ex)
            {
                exceptionHandler.HandleExceptions(ex);
            }
        }
    }

    private async Task UpdateFighter(FighterDto fighterDto)
    {
        var options = new DialogOptions { CloseOnEscapeKey = true, CloseButton = true };
        var parameters = new DialogParameters<UpdateFighterDialog>
        {
            {
                x => x.FormModel,
                new UpdateFighter.FormModel
                {
                    Id = fighterDto.Id,
                    FirstName = fighterDto.FirstName,
                    LastName = fighterDto.LastName,
                    Nickname = fighterDto.Nickname,
                    InstagramUrl = fighterDto.InstagramUrl,
                    ImageBase64 = ""
                }
            },
            { x => x.Url, fighterDto.Image?.Url }
        };

        var dialog =
            await dialogService.ShowAsync<UpdateFighterDialog>(localizer[nameof(AppStrings.UpdateFighter)],
                parameters, options);
        var result = await dialog.Result;
        if (result is { Canceled: false })
        {
            await _table.ReloadServerData();
        }
    }

    private async Task CreateFighter()
    {
        var options = new DialogOptions { CloseOnEscapeKey = true, CloseButton = true };
        var parameters = new DialogParameters<CreateFighterDialog>
        {
            { x => x.FormModel, new CreateFighter.FormModel() }
        };

        var dialog =
            await dialogService.ShowAsync<CreateFighterDialog>(localizer[nameof(AppStrings.CreateFighter)],
                parameters, options);
        var result = await dialog.Result;
        if (result is { Canceled: false })
        {
            await _table.ReloadServerData();
        }
    }

    private void RedirectToFighterProfile(int fighterId)
    {
        navigationManager.NavigateTo($"/fighter/{fighterId}");
    }
}