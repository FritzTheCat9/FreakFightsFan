using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Blazor.Pages.Error;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Federations.Commands;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;

namespace FreakFightsFan.Blazor.Pages.Federations;

public partial class UpdateFederationDialog : ComponentBase
{
    private CustomValidator _customValidator;

    [CascadingParameter] public MudDialogInstance MudDialog { get; set; }

    [Parameter] public UpdateFederation.FormModel FormModel { get; set; } = new();
    [Parameter] public string Url { get; set; }

    [Inject] public IExceptionHandler ExceptionHandler { get; set; }
    [Inject] public IFederationApiClient FederationApiClient { get; set; }
    [Inject] public IStringLocalizer<App> Localizer { get; set; }

    private async Task HandleValidSubmit()
    {
        try
        {
            await FederationApiClient.UpdateFederation(FormModel);
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