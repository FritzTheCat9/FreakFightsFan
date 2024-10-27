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

public partial class CreateEventDialog : ComponentBase
{
    private CustomValidator _customValidator;

    private MyDictionaryItemDto City { get; set; }
    private MyDictionaryItemDto Hall { get; set; }

    [CascadingParameter] public MudDialogInstance MudDialog { get; set; }

    [Parameter] public CreateEvent.Command Command { get; set; } = new();

    [Inject] public IExceptionHandler ExceptionHandler { get; set; }
    [Inject] public IEventApiClient EventApiClient { get; set; }

    [Inject] public IStringLocalizer<App> Localizer { get; set; }

    private async Task HandleValidSubmit()
    {
        try
        {
            await EventApiClient.CreateEvent(Command);
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