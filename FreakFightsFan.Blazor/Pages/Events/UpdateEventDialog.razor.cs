using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Blazor.Pages.Error;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.DictionaryItems.Responses;
using FreakFightsFan.Shared.Features.Events.Commands;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;

namespace FreakFightsFan.Blazor.Pages.Events;

public partial class UpdateEventDialog(
    IExceptionHandler exceptionHandler,
    IEventApiClient eventApiClient,
    IStringLocalizer<App> localizer)
    : ComponentBase
{
    private CustomValidator _customValidator;

    [CascadingParameter] public MudDialogInstance MudDialog { get; set; }
    [Parameter] public UpdateEvent.Command Command { get; set; } = new();
    [Parameter] public MyDictionaryItemDto City { get; set; }
    [Parameter] public MyDictionaryItemDto Hall { get; set; }

    private async Task HandleValidSubmit()
    {
        try
        {
            await eventApiClient.UpdateEvent(Command);
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