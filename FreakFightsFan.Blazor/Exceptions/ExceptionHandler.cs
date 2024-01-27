using FreakFightsFan.Shared.Exceptions;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace FreakFightsFan.Blazor.Exceptions
{
    public interface IExceptionHandler
    {
        void HandleExceptions(Exception exception);
        void AddServerValidationErrorsToForm(MyValidationException validationException, EditContext editContext);
        void RemoveFieldValidationErrors(FieldIdentifier fieldIdentifier, EditContext editContext);
    }

    public class ExceptionHandler : IExceptionHandler
    {
        private readonly NavigationManager _navigationManager;
        private readonly ValidationErrors _validationErrors;

        public ExceptionHandler(
            NavigationManager navigationManager,
            ValidationErrors validationErrors)
        {
            _navigationManager = navigationManager;
            _validationErrors = validationErrors;
        }

        public void HandleExceptions(Exception exception)
        {
            switch (exception)
            {
                case MyUnauthorizedException unauthorizedException:
                    _navigationManager.NavigateTo("error/unauthorized-error");
                    break;
                case MyForbiddenException forbiddenException:
                    _navigationManager.NavigateTo("error/forbidden-error");
                    break;
                case MyNotFoundException notFoundException:
                    _navigationManager.NavigateTo("error/notfound-error");
                    break;
                case MyValidationException validationException:
                    _validationErrors.Errors = validationException.Errors;
                    _navigationManager.NavigateTo("error/validation-error");
                    break;
                case MyServerException serverException:
                    _navigationManager.NavigateTo("error/server-error");
                    break;
                default:
                    //TODO: log other HttpService exceptions to file on the server
                    _navigationManager.NavigateTo("error/server-error");
                    break;
            }
        }

        public void AddServerValidationErrorsToForm(
            MyValidationException validationException,
            EditContext editContext)
        {
            ValidationMessageStore validationMessageStore = new(editContext);

            validationMessageStore.Clear();

            foreach (var (fieldName, errors) in validationException.Errors)
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
}
