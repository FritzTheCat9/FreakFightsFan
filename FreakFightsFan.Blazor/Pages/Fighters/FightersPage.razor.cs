using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Blazor.Localization;
using FreakFightsFan.Blazor.Shared;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Fighters.Queries;
using FreakFightsFan.Shared.Features.Fighters.Responses;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;

namespace FreakFightsFan.Blazor.Pages.Fighters
{
    public partial class FightersPage : ComponentBase
    {
        private List<BreadcrumbItem> _items;
        private MudTable<FighterDto> _table;

        private string _searchString = "";
        private PagedList<FighterDto> _myFighters;

        [Inject] public IExceptionHandler ExceptionHandler { get; set; }
        [Inject] public IFighterApiClient FighterApiClient { get; set; }

        [Inject] public IStringLocalizer<App> Localizer { get; set; }

        [Inject] public IDialogService DialogService { get; set; }
        [Inject] public NavigationManager NavigationManager { get; set; }

        protected override void OnInitialized()
        {
            _items =
            [
                new(Localizer[nameof(AppStrings.Fighters)], href: null, disabled: true),
            ];
        }

        private async Task<TableData<FighterDto>> ServerReload(TableState state, CancellationToken token)
        {
            var query = new GetAllFighters.Query
            {
                Page = state.Page + 1,
                PageSize = state.PageSize,
                SortColumn = state.SortLabel,
                SortOrder = ((SortOrder)state.SortDirection),
                SearchTerm = _searchString,
            };

            try
            {
                _myFighters = await FighterApiClient.GetAllFighters(query);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleExceptions(ex);
                return new() { TotalItems = 0, Items = [] };
            }

            return new()
            {
                TotalItems = _myFighters.TotalCount,
                Items = _myFighters.Items
            };
        }

        private async Task DeleteFighter(int id)
        {
            var options = new DialogOptions() { CloseOnEscapeKey = true, CloseButton = true };
            var dialog = await DialogService.ShowAsync<DeleteDialog>(@Localizer[nameof(AppStrings.Delete)], options);

            var result = await dialog.Result;
            if (!result.Canceled)
            {
                try
                {
                    await FighterApiClient.DeleteFighter(id);
                    await _table.ReloadServerData();
                }
                catch (Exception ex)
                {
                    ExceptionHandler.HandleExceptions(ex);
                }
            }
        }

        private async Task UpdateFighter(FighterDto fighterDto)
        {
            var options = new DialogOptions() { CloseOnEscapeKey = true, CloseButton = true };
            var parameters = new DialogParameters<UpdateFighterDialog>
            {
                {
                    x => x.FormModel,
                    new()
                    {
                        Id = fighterDto.Id,
                        FirstName = fighterDto.FirstName,
                        LastName = fighterDto.LastName,
                        Nickname = fighterDto.Nickname,
                        InstagramUrl = fighterDto.InstagramUrl,
                        ImageBase64 = ""
                    }
                },
                {
                    x => x.Url,
                    fighterDto.Image?.Url
                }
            };

            var dialog = await DialogService.ShowAsync<UpdateFighterDialog>(Localizer[nameof(AppStrings.UpdateFighter)], parameters, options);
            var result = await dialog.Result;
            if (!result.Canceled)
                await _table.ReloadServerData();
        }

        private async Task CreateFighter()
        {
            var options = new DialogOptions() { CloseOnEscapeKey = true, CloseButton = true };
            var parameters = new DialogParameters<CreateFighterDialog>
            {
                { 
                    x => x.FormModel, 
                    new() 
                }
            };

            var dialog = await DialogService.ShowAsync<CreateFighterDialog>(Localizer[nameof(AppStrings.CreateFighter)], parameters, options);
            var result = await dialog.Result;
            if (!result.Canceled)
                await _table.ReloadServerData();
        }

        private void RedirectToFighterProfile(int fighterId)
            => NavigationManager.NavigateTo($"/fighter/{fighterId}");
    }
}