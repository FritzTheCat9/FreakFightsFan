using FreakFightsFan.Shared.Exceptions;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.Collections;
using System.Reflection;

namespace FreakFightsFan.Blazor.Pages.Error
{
    public interface IExceptionHandler
    {
        void HandleExceptions(Exception exception);
        void AddServerValidationErrorsToForm(MyValidationException validationException, EditContext editContext);
        void RemoveFieldValidationErrors(FieldIdentifier fieldIdentifier, EditContext editContext);
        void ClearValidationErrors(EditForm editForm);
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

        public void ClearValidationErrors(EditForm editForm)
        {
            EditFormExtensions.ClearValidationMessages(editForm, true);
        }
    }
}

/// <summary>
/// Contains extension methods for working with the <see cref="EditForm"/> class.
/// </summary>
public static class EditFormExtensions
{
    /// <summary>
    /// Clears all validation messages from the <see cref="EditContext"/> of the given <see cref="EditForm"/>.
    /// </summary>
    /// <param name="editForm">The <see cref="EditForm"/> to use.</param>
    /// <param name="revalidate">
    /// Specifies whether the <see cref="EditContext"/> of the given <see cref="EditForm"/> should revalidate after all validation messages have been cleared.
    /// </param>
    /// <param name="markAsUnmodified">
    /// Specifies whether the <see cref="EditContext"/> of the given <see cref="EditForm"/> should be marked as unmodified.
    /// This will affect the assignment of css classes to a form's input controls in Blazor.
    /// </param>
    /// <remarks>
    /// This extension method should be on EditContext, but EditForm is being used until the fix for issue
    /// <see href="https://github.com/dotnet/aspnetcore/issues/12238"/> is officially released.
    /// </remarks>
    public static void ClearValidationMessages(this EditForm editForm, bool revalidate = false, bool markAsUnmodified = false)
    {
        var bindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

        object GetInstanceField(Type type, object instance, string fieldName)
        {
            var fieldInfo = type.GetField(fieldName, bindingFlags);
            return fieldInfo.GetValue(instance);
        }

        var editContext = editForm.EditContext == null
            ? GetInstanceField(typeof(EditForm), editForm, "_fixedEditContext") as EditContext
            : editForm.EditContext;

        var fieldStates = GetInstanceField(typeof(EditContext), editContext, "_fieldStates");
        var clearMethodInfo = typeof(HashSet<ValidationMessageStore>).GetMethod("Clear", bindingFlags);

        foreach (DictionaryEntry kv in (IDictionary)fieldStates)
        {
            var messageStores = GetInstanceField(kv.Value.GetType(), kv.Value, "_validationMessageStores");
            clearMethodInfo.Invoke(messageStores, null);
        }

        if (markAsUnmodified)
            editContext.MarkAsUnmodified();

        if (revalidate)
            editContext.Validate();
    }
}
