using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Blazor.Localization;
using FreakFightsFan.Blazor.Shared;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Users.Helpers;
using FreakFightsFan.Shared.Features.Users.Queries;
using FreakFightsFan.Shared.Features.Users.Responses;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;

namespace FreakFightsFan.Blazor.Pages.Users;

public partial class UsersPage : ComponentBase
{
    private List<BreadcrumbItem> _items;
    private PagedList<UserDto> _myUsers;
    private string _searchString = "";
    private MudTable<UserDto> _table;

    [Inject] public IExceptionHandler ExceptionHandler { get; set; }
    [Inject] public IUserApiClient UserApiClient { get; set; }
    [Inject] public IDialogService DialogService { get; set; }
    [Inject] public IStringLocalizer<App> Localizer { get; set; }

    protected override void OnInitialized()
    {
        _items =
        [
            new BreadcrumbItem(Localizer[nameof(AppStrings.Users)], null, true)
        ];
    }

    private async Task<TableData<UserDto>> ServerReload(TableState state, CancellationToken token)
    {
        var query = new GetAllUsers.Query
        {
            Page = state.Page + 1,
            PageSize = state.PageSize,
            SortColumn = state.SortLabel,
            SortOrder = (SortOrder)state.SortDirection,
            SearchTerm = _searchString
        };

        try
        {
            _myUsers = await UserApiClient.GetAllUsers(query);
        }
        catch (Exception ex)
        {
            ExceptionHandler.HandleExceptions(ex);
            return new TableData<UserDto> { TotalItems = 0, Items = [] };
        }

        return new TableData<UserDto> { TotalItems = _myUsers.TotalCount, Items = _myUsers.Items };
    }

    private async Task PromoteUser(int id)
    {
        var options = new DialogOptions { CloseOnEscapeKey = true, CloseButton = true };
        var parameters = new DialogParameters<InformationDialog>
        {
            { x => x.ContentText, Localizer[nameof(AppStrings.IncreaseUserPermissionsQuestion)] }
        };

        var dialog =
            await DialogService.ShowAsync<InformationDialog>(Localizer[nameof(AppStrings.IncreaseUserPermissions)],
                parameters, options);
        var result = await dialog.Result;
        if (result is { Canceled: false })
        {
            await UserApiClient.PromoteUser(id);
            await _table.ReloadServerData();
        }
    }

    private async Task DegradeUser(int id)
    {
        var options = new DialogOptions { CloseOnEscapeKey = true, CloseButton = true };
        var parameters = new DialogParameters<InformationDialog>
        {
            { x => x.ContentText, Localizer[nameof(AppStrings.DecreaseUserPermissionsQuestion)] }
        };

        var dialog =
            await DialogService.ShowAsync<InformationDialog>(Localizer[nameof(AppStrings.DecreaseUserPermissions)],
                parameters, options);
        var result = await dialog.Result;
        if (result is { Canceled: false })
        {
            await UserApiClient.DegradeUser(id);
            await _table.ReloadServerData();
        }
    }

    private static string GetUserHighestPolicy(UserDto user)
    {
        return user.IsSuperAdmin ? Policy.SuperAdmin : user.IsAdmin ? Policy.Admin : Policy.User;
    }

    private static Color GetColorBasedOnPolicy(string policy)
    {
        return policy switch
        {
            Policy.SuperAdmin => Color.Info,
            Policy.Admin => Color.Error,
            _ => Color.Success
        };
    }
}