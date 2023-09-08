using FreakFightsFan.Shared.Exceptions;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace FreakFightsFan.Blazor.Pages.Error
{
    public interface IExceptionHandler
    {
        void HandleExceptions(CustomException exception);
        void AddServerValidationErrorsToForm(MyValidationException validationException, EditContext editContext, ValidationMessageStore validationMessageStore);
    }

    public class ExceptionHandler : IExceptionHandler
    {
        private readonly NavigationManager _navigationManager;
        private readonly ValidationErrors _validationErrors;

        public ExceptionHandler(NavigationManager navigationManager, ValidationErrors validationErrors) 
        {
            _navigationManager = navigationManager;
            _validationErrors = validationErrors;
        }

        public void HandleExceptions(CustomException exception)
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
                default:
                    _navigationManager.NavigateTo("error/server-error");
                    break;
            }
        }

        public void AddServerValidationErrorsToForm(
            MyValidationException validationException, 
            EditContext editContext, 
            ValidationMessageStore validationMessageStore)
        {
            validationMessageStore?.Clear();

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
    }
}
