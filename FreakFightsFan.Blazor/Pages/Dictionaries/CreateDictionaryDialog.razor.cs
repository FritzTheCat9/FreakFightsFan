using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Blazor.Pages.Error;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Dictionaries.Commands;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;

namespace FreakFightsFan.Blazor.Pages.Dictionaries;

public partial class CreateDictionaryDialog(
    IExceptionHandler exceptionHandler,
    IMyDictionaryApiClient myDictionaryApiClient,
    IStringLocalizer<App> localizer)
    : ComponentBase
{
    private CustomValidator _customValidator;

    [CascadingParameter] public MudDialogInstance MudDialog { get; set; }
    [Parameter] public CreateMyDictionary.Command Command { get; set; } = new();

    private async Task HandleValidSubmit()
    {
        try
        {
            await myDictionaryApiClient.CreateMyDictionary(Command);
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