using FreakFightsFan.Shared;
using FreakFightsFan.Shared.Features.Images.Helpers;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.Localization;
using System.Linq.Expressions;

namespace FreakFightsFan.Blazor.Components;

public partial class FritzFileInput
{
    private readonly int _maxFileSize = ImageConsts.MaxFileSize;
    private readonly string _allowedFileTypesString = ImageHelpers.MakeAllowedFileTypesString(ImageConsts.AllowedFileTypes);

    private FieldIdentifier _fileFieldIdentifier;
    private FieldIdentifier _imageBase64FieldIdentifier;

    [CascadingParameter] public EditContext EditContext { get; set; }

    [Parameter] public IBrowserFile File { get; set; }
    [Parameter] public EventCallback<IBrowserFile> FileChanged { get; set; }
    [Parameter] public Expression<Func<IBrowserFile>> ForFile { get; set; }

    [Parameter] public string ImageBase64 { get; set; }
    [Parameter] public EventCallback<string> ImageBase64Changed { get; set; }
    [Parameter] public Expression<Func<string>> ForImageBase64 { get; set; }

    [Parameter] public string Url { get; set; }
    private bool _isImageValid;

    [Inject] public IStringLocalizer<App> Localizer { get; set; }
    [Inject] public IStringLocalizer<ValidationMessage> SharedLocalizer { get; set; }

    protected override void OnInitialized()
    {
        SetIsImageValid(ImageBase64);
    }

    private void SetIsImageValid(string imageBase64)
    {
        if (!string.IsNullOrEmpty(imageBase64))
        {
            _isImageValid = true;
        }
    }

    protected override void OnParametersSet()
    {
        if (ForFile is not null)
        {
            _fileFieldIdentifier = FieldIdentifier.Create(ForFile);
        }

        if (ForImageBase64 is not null)
        {
            _imageBase64FieldIdentifier = FieldIdentifier.Create(ForImageBase64);
        }
    }

    private async Task OnFileChanged(IBrowserFile file)
    {
        File = file;
        await FileChanged.InvokeAsync(file);
        ValidateFile();
    }

    private async Task OnImageBase64Changed(string url)
    {
        ImageBase64 = url;
        await ImageBase64Changed.InvokeAsync(url);
        ValidateImageBase64();
    }

    private void ValidateFile()
    {
        if (!string.IsNullOrEmpty(_fileFieldIdentifier.FieldName))
        {
            EditContext?.NotifyFieldChanged(_fileFieldIdentifier);
        }
    }

    private void ValidateImageBase64()
    {
        if (!string.IsNullOrEmpty(_imageBase64FieldIdentifier.FieldName))
        {
            EditContext?.NotifyFieldChanged(_imageBase64FieldIdentifier);
        }
    }

    private async Task UploadFiles(InputFileChangeEventArgs e)
    {
        try
        {
            var file = e.File;

            await OnFileChanged(file);
            await OnImageBase64Changed(null);

            if (file is null)
            {
                _isImageValid = false;
                return;
            }

            var fileValidator = new ImageHelpers.ImageValidator(SharedLocalizer);
            var validationResult = await fileValidator.ValidateAsync(e.File);
            if (!validationResult.IsValid)
            {
                _isImageValid = false;
                return;
            }

            var url = await GetImageBase64Url(file);
            _isImageValid = true;

            await OnImageBase64Changed(url);
        }
        catch (Exception)
        {
            // File was not picked
        }
    }

    private async Task<string> GetImageBase64Url(IBrowserFile file)
    {
        var buffer = new byte[file.Size];
        await file.OpenReadStream(_maxFileSize).ReadAsync(buffer);

        var imageBase64 = Convert.ToBase64String(buffer);
        var url = $"data:{file.ContentType};base64,{imageBase64}";

        return url;
    }
}