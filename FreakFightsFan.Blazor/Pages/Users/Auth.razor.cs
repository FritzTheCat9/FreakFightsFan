using FreakFightsFan.Blazor.Auth;
using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Blazor.Localization;
using FreakFightsFan.Blazor.Shared;
using FreakFightsFan.Shared.Features.Users.Helpers;
using FreakFightsFan.Shared.Features.Users.Responses;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;

namespace FreakFightsFan.Blazor.Pages.Users
{
    public partial class Auth : ComponentBase
    {
        [Parameter] public EventCallback<ThemeColor> ChangeThemeColor { get; set; }

        [Inject] public IExceptionHandler ExceptionHandler { get; set; }
        [Inject] public IUserApiClient UserApiClient { get; set; }
        [Inject] public IAuthService AuthService { get; set; }

        [Inject] public IStringLocalizer<App> Localizer { get; set; }

        [Inject] public IDialogService DialogService { get; set; }

        private async Task Login()
        {
            var options = new DialogOptions() { CloseOnEscapeKey = true, CloseButton = true };
            var parameters = new DialogParameters<LoginDialog>
            {
                { 
                    x => x.Command, 
                    new() 
                }
            };

            var dialog = await DialogService.ShowAsync<LoginDialog>(Localizer[nameof(AppStrings.Login)], parameters, options);
            var result = await dialog.Result;
            if (!result.Canceled)
            {
                if (result.Data is JwtDto token)
                {
                    await AuthService.Login(token);

                    await LoadUserTheme();
                }
            }
        }

        private async Task LoadUserTheme()
        {
            var userId = await AuthService.GetCurrentUserId();
            if (userId is null)
                return;

            try
            {
                var user = await UserApiClient.GetUser(userId.Value);

                await ChangeThemeColor.InvokeAsync(user.ThemeColor);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleExceptions(ex);
            }
        }

        private async Task Register()
        {
            var options = new DialogOptions() { CloseOnEscapeKey = true, CloseButton = true };
            var parameters = new DialogParameters<RegisterDialog>
            {
                { 
                    x => x.Command, 
                    new() 
                }
            };

            var dialog = await DialogService.ShowAsync<RegisterDialog>(Localizer[nameof(AppStrings.Register)], parameters, options);
            var result = await dialog.Result;
            if (!result.Canceled)
                await OpenRegistrationSuccessDialog();
        }

        private async Task OpenRegistrationSuccessDialog()
        {
            var dialogOptions = new DialogOptions() { CloseOnEscapeKey = true, CloseButton = true };
            var parameters = new DialogParameters<SuccessDialog>
            {
                { 
                    x => x.ContentText, 
                    Localizer[nameof(AppStrings.AccountCreated)] 
                }
            };

            var dialog = await DialogService.ShowAsync<SuccessDialog>(Localizer[nameof(AppStrings.Success)], parameters, dialogOptions);
        }

        private async Task Logout()
        {
            await AuthService.Logout("/");
        }
    }
}