using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Blazor.Pages.Error;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Fighters.Commands;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;

namespace FreakFightsFan.Blazor.Pages.Fighters
{
    public partial class UpdateFighterDialog : ComponentBase
    {
        private CustomValidator _customValidator;

        [CascadingParameter] public MudDialogInstance MudDialog { get; set; }

        [Parameter] public UpdateFighter.Command Command { get; set; } = new();
        [Parameter] public string Url { get; set; }

        [Inject] IFighterApiClient FighterApiClient { get; set; }
        [Inject] IExceptionHandler ExceptionHandler { get; set; }
        [Inject] IStringLocalizer<App> Localizer { get; set; }

        private async Task HandleValidSubmit()
        {
            try
            {
                await FighterApiClient.UpdateFighter(Command);
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