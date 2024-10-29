using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Components;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Blazor.Pages.Error;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Users.Commands;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;

namespace FreakFightsFan.Blazor.Pages.Users;

public partial class LoginDialog : ComponentBase
{
    private CustomValidator _customValidator;
    private FritzProcessingButton _processingButton;

    [CascadingParameter] public MudDialogInstance MudDialog { get; set; }

    [Parameter] public Login.Command Command { get; set; } = new();

    [Inject] public IExceptionHandler ExceptionHandler { get; set; }
    [Inject] public IUserApiClient UserApiClient { get; set; }
    [Inject] public IStringLocalizer<App> Localizer { get; set; }

    private async Task HandleValidSubmit()
    {
        try
        {
            _processingButton.SetProcessing(true);

            var token = await UserApiClient.Login(Command);
            MudDialog.Close(DialogResult.Ok(token));
        }
        catch (MyValidationException validationException)
        {
            _customValidator.DisplayErrors(validationException.Errors);
        }
        catch (Exception ex)
        {
            ExceptionHandler.HandleExceptions(ex);
        }
        finally
        {
            _processingButton.SetProcessing(false);
        }
    }
}