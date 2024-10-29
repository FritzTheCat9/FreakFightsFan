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

public partial class CreateEventDialog(
    IExceptionHandler exceptionHandler,
    IEventApiClient eventApiClient,
    IStringLocalizer<App> localizer)
    : ComponentBase
{
    private CustomValidator _customValidator;
    private MyDictionaryItemDto City { get; set; }
    private MyDictionaryItemDto Hall { get; set; }

    [CascadingParameter] public MudDialogInstance MudDialog { get; set; }
    [Parameter] public CreateEvent.Command Command { get; set; } = new();

    private async Task HandleValidSubmit()
    {
        try
        {
            await eventApiClient.CreateEvent(Command);
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