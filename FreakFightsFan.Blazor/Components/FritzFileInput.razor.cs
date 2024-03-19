using FluentValidation;
using FreakFightsFan.Shared.Features.Images.Helpers;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.Localization;
using MudBlazor;

namespace FreakFightsFan.Blazor.Components
{
    public partial class FritzFileInput: MudTextField<string>
    {
        private readonly int _maxFileSize = ImageConsts.MaxFileSize;
        private readonly List<string> _allowedFileTypes = ImageConsts.AllowedFileTypes;
        private readonly string _allowedFileTypesString = ImageHelpers.MakeAllowedFileTypesString(ImageConsts.AllowedFileTypes);
        
        private IBrowserFile File { get; set; }
        private bool _isImageValid;

        [Parameter] public string Url { get; set; }
        [Parameter] public EventCallback<string> OnImageBase64Changed { get; set; }

        [Inject] public IStringLocalizer<App> Localizer { get; set; }

        protected override void OnInitialized() 
            => SetIsImageValid(Value);

        private async Task OnValueChanged(string value)
        {
            await SetValueAsync(value);
            await OnImageBase64Changed.InvokeAsync(Value);
        }

        private void SetIsImageValid(string imageBase64)
        {
            if (!string.IsNullOrEmpty(imageBase64))
            {
                _isImageValid = true;
            }
        }

        private async void UploadFiles(InputFileChangeEventArgs e)
        {
            var validationErrors = ValidateFile(e.File);
            if (validationErrors.Any())
            {
                _isImageValid = false;
                await OnValueChanged(null);
                StateHasChanged();
                return;
            }

            var file = e.File;
            var buffer = new byte[file.Size];
            await file.OpenReadStream(_maxFileSize).ReadAsync(buffer);
            var imageBase64 = Convert.ToBase64String(buffer);
            string dataUrl = $"data:{file.ContentType};base64,{imageBase64}";
            await OnValueChanged(dataUrl);

            _isImageValid = true;
            StateHasChanged();
        }

        private IDictionary<string, List<string>> ValidateFile(IBrowserFile file)
        {
            if (file == null)
                return new Dictionary<string, List<string>>();

            var validator = new FileFluentValidator(_maxFileSize, _allowedFileTypes, _allowedFileTypesString);
            var result = validator.Validate(file);

            var validationErrors = new Dictionary<string, List<string>>();
            if (!result.IsValid)
            {
                validationErrors = result.Errors
                    .GroupBy(failure => failure.PropertyName)
                    .ToDictionary(group => group.Key, group => group.Select(failure => failure.ErrorMessage).ToList());
            }
            return validationErrors;
        }

        private class FileFluentValidator : AbstractValidator<IBrowserFile>
        {
            private readonly int _maxFileSize;
            private readonly List<string> _allowedFileTypes;
            private readonly string _allowedFileTypesString;

            public FileFluentValidator(int maxFileSize, List<string> allowedFileTypes, string allowedFileTypesString)
            {
                _maxFileSize = maxFileSize;
                _allowedFileTypes = allowedFileTypes;
                _allowedFileTypesString = allowedFileTypesString;

                When(x => x != null, () =>
                {
                    RuleFor(x => x.Size)
                    .Must(x => x <= _maxFileSize)
                    .WithMessage($"The maximum file size is {_maxFileSize} bytes");

                    RuleFor(x => x.ContentType)
                    .Must(x => _allowedFileTypes.Contains(x))
                    .WithMessage($"Allowed image types: {_allowedFileTypesString}");
                });
            }
        }
    }
}