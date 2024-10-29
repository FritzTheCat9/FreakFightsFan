using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Blazor.Pages.Error;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Fighters.Commands;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;

namespace FreakFightsFan.Blazor.Pages.Fighters;

public partial class UpdateFighterDialog(
    IFighterApiClient fighterApiClient,
    IExceptionHandler exceptionHandler,
    IStringLocalizer<App> localizer)
    : ComponentBase
{
    private CustomValidator _customValidator;

    [CascadingParameter] public MudDialogInstance MudDialog { get; set; }
    [Parameter] public UpdateFighter.FormModel FormModel { get; set; } = new();
    [Parameter] public string Url { get; set; }

    private async Task HandleValidSubmit()
    {
        try
        {
            await fighterApiClient.UpdateFighter(FormModel);
            MudDialog.Close(DialogResult.Ok(true));
        }
        catch (MyValidationException validationException)
        {
            _customValidator.DisplayErrors(validationException.Errors);
        }
        catch (Exception ex)
        {
            exceptionHandler.HandleExceptions(ex);
        }
    }
}