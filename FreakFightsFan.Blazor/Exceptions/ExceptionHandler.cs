using FreakFightsFan.Shared.Exceptions;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace FreakFightsFan.Blazor.Exceptions;

public interface IExceptionHandler
{
    void HandleExceptions(Exception exception);
    void AddServerValidationErrorsToForm(MyValidationException validationException, EditContext editContext);
    void RemoveFieldValidationErrors(FieldIdentifier fieldIdentifier, EditContext editContext);
}

public class ExceptionHandler(
    NavigationManager navigationManager,
    ValidationErrors validationErrors)
    : IExceptionHandler
{
    public void HandleExceptions(Exception exception)
    {
        switch (exception)
        {
            case MyUnauthorizedException:
                navigationManager.NavigateTo("error/unauthorized-error");
                break;
            case MyForbiddenException:
                navigationManager.NavigateTo("error/forbidden-error");
                break;
            case MyNotFoundException:
                navigationManager.NavigateTo("error/notfound-error");
                break;
            case MyValidationException validationException:
                validationErrors.Errors = validationException.Errors;
                navigationManager.NavigateTo("error/validation-error");
                break;
            case MyServerException:
                navigationManager.NavigateTo("error/server-error");
                break;
            default:
                //TODO: log other HttpService exceptions to file on the server
                navigationManager.NavigateTo("error/server-error");
                break;
        }
    }

    public void AddServerValidationErrorsToForm(
        MyValidationException validationException,
        EditContext editContext)
    {
        ValidationMessageStore validationMessageStore = new(editContext);

        validationMessageStore.Clear();

        foreach ((string fieldName, List<string> errors) in validationException.Errors)
        {
            var fieldIdentifier = new FieldIdentifier(editContext.Model, fieldName);
            foreach (var error in errors)
            {
                validationMessageStore.Add(fieldIdentifier, error);
            }
        }

        editContext.NotifyValidationStateChanged();
    }

    public void RemoveFieldValidationErrors(
        FieldIdentifier fieldIdentifier,
        EditContext editContext)
    {
        ValidationMessageStore validationMessageStore = new(editContext);

        validationMessageStore.Add(fieldIdentifier, new List<string>());

        editContext.NotifyValidationStateChanged();
    }
}