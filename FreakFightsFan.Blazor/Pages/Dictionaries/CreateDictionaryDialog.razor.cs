using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Blazor.Pages.Error;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Dictionaries.Commands;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;

namespace FreakFightsFan.Blazor.Pages.Dictionaries
{
    public partial class CreateDictionaryDialog : ComponentBase
    {
        private CustomValidator _customValidator;

        [CascadingParameter] public MudDialogInstance MudDialog { get; set; }

        [Parameter] public CreateMyDictionary.Command Command { get; set; } = new();

        [Inject] public IExceptionHandler ExceptionHandler { get; set; }
        [Inject] public IMyDictionaryApiClient MyDictionaryApiClient { get; set; }

        [Inject] public IStringLocalizer<App> Localizer { get; set; }

        private async Task HandleValidSubmit()
        {
            try
            {
                await MyDictionaryApiClient.CreateMyDictionary(Command);
                MudDialog.Close(DialogResult.Ok(true));
            }
            catch (MyValidationException validationException)
            {
                _customValidator.DisplayErrors(validationException.Errors);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleExceptions(ex);
            }
        }
    }
}