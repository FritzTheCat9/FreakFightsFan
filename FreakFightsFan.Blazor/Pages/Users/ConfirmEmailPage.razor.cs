using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Components;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Blazor.Pages.Error;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Users.Commands;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Blazor.Pages.Users;

public partial class ConfirmEmailPage(
    IExceptionHandler exceptionHandler,
    IUserApiClient userApiClient,
    IStringLocalizer<App> localizer)
    : ComponentBase
{
    private CustomValidator _customValidator;
    private bool _parsingError;
    private FritzProcessingButton _processingButton;
    private bool _success;
    private ConfirmEmail.Command Command { get; } = new();

    [SupplyParameterFromQuery] public string Email { get; set; }
    [SupplyParameterFromQuery] public string Token { get; set; }

    protected override void OnParametersSet()
    {
        try
        {
            Command.Email = Uri.UnescapeDataString(Email);
            Command.Token = Uri.UnescapeDataString(Token);
        }
        catch (Exception)
        {
            _parsingError = true;
        }
    }

    private async Task OnValidSubmit()
    {
        try
        {
            _processingButton.SetProcessing(true);

            _success = await userApiClient.ConfirmEmail(Command);
        }
        catch (MyValidationException validationException)
        {
            _customValidator.DisplayErrors(validationException.Errors);
        }
        catch (Exception ex)
        {
            exceptionHandler.HandleExceptions(ex);
        }
        finally
        {
            _processingButton.SetProcessing(false);
        }
    }
}