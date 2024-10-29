using FreakFightsFan.Blazor.Auth;
using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Blazor.Localization;
using FreakFightsFan.Blazor.Shared;
using FreakFightsFan.Shared.Features.Users.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using FreakFightsFan.Shared.Features.Users.Responses;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;

namespace FreakFightsFan.Blazor.Pages.Users;

public partial class Auth(
    IExceptionHandler exceptionHandler,
    IUserApiClient userApiClient,
    IAuthService authService,
    IStringLocalizer<App> localizer,
    IDialogService dialogService)
    : ComponentBase
{
    [Parameter] public EventCallback<ThemeColor> ChangeThemeColor { get; set; }

    private async Task Login()
    {
        var options = new DialogOptions { CloseOnEscapeKey = true, CloseButton = true };
        var parameters = new DialogParameters<LoginDialog> { { x => x.Command, new Login.Command() } };

        var dialog =
            await dialogService.ShowAsync<LoginDialog>(localizer[nameof(AppStrings.Login)], parameters, options);
        var result = await dialog.Result;
        if (result is { Canceled: false, Data: JwtDto token })
        {
            await authService.Login(token);
            await LoadUserTheme();
        }
    }

    private async Task LoadUserTheme()
    {
        var userId = await authService.GetCurrentUserId();
        if (userId is null)
        {
            return;
        }

        try
        {
            var user = await userApiClient.GetUser(userId.Value);

            await ChangeThemeColor.InvokeAsync(user.ThemeColor);
        }
        catch (Exception ex)
        {
            exceptionHandler.HandleExceptions(ex);
        }
    }

    private async Task Register()
    {
        var options = new DialogOptions { CloseOnEscapeKey = true, CloseButton = true };
        var parameters = new DialogParameters<RegisterDialog> { { x => x.Command, new Register.Command() } };

        var dialog =
            await dialogService.ShowAsync<RegisterDialog>(localizer[nameof(AppStrings.Register)], parameters,
                options);
        var result = await dialog.Result;
        if (result is { Canceled: false })
        {
            await OpenRegistrationSuccessDialog();
        }
    }

    private async Task OpenRegistrationSuccessDialog()
    {
        var dialogOptions = new DialogOptions { CloseOnEscapeKey = true, CloseButton = true };
        var parameters = new DialogParameters<SuccessDialog>
        {
            { x => x.ContentText, localizer[nameof(AppStrings.AccountCreated)] }
        };

        var dialog =
            await dialogService.ShowAsync<SuccessDialog>(localizer[nameof(AppStrings.Success)], parameters,
                dialogOptions);
    }

    private async Task Logout()
    {
        await authService.Logout("/");
    }
}