using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Blazor.Pages.Error;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.DictionaryItems.Commands;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;

namespace FreakFightsFan.Blazor.Pages.DictionaryItems
{
    public partial class CreateDictionaryItemDialog : ComponentBase
    {
        private CustomValidator _customValidator;

        [CascadingParameter] public MudDialogInstance MudDialog { get; set; }

        [Parameter] public CreateMyDictionaryItem.Command Command { get; set; } = new();

        [Inject] public IExceptionHandler ExceptionHandler { get; set; }
        [Inject] public IMyDictionaryItemApiClient MyDictionaryItemApiClient { get; set; }

        [Inject] public IStringLocalizer<App> Localizer { get; set; }

        private async Task HandleValidSubmit()
        {
            try
            {
                await MyDictionaryItemApiClient.CreateMyDictionaryItem(Command);
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