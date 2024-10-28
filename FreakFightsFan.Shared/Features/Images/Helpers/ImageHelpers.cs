using FluentValidation;
using FreakFightsFan.Shared.Localization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Shared.Features.Images.Helpers;

public static class ImageHelpers
{
    public static bool HaveValidFileType(string imageBase64, List<string> allowedFileTypes)
    {
        return allowedFileTypes.Contains(GetImageContentType(imageBase64)); // "data:image/png;base64,xDGYcSWd..."
    }

    public static bool HaveValidSize(string imageBase64, int maxFileSize)
    {
        try
        {
            return GetImageData(imageBase64).Length <= maxFileSize;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public static string MakeAllowedFileTypesString(List<string> allowedFileTypes)
    {
        var allowedFileTypesString = "";
        for (var i = 0; i < allowedFileTypes.Count; i++)
        {
            var imageType = allowedFileTypes[i].Substring(6); // without 'image/'

            allowedFileTypesString += "." + imageType;
            if (i != allowedFileTypes.Count - 1)
            {
                allowedFileTypesString += ", ";
            }
        }

        return allowedFileTypesString;
    }

    /* -------------------- Model Helpers -------------------- */

    public static byte[] GetImageData(string imageBase64)
    {
        return Convert.FromBase64String(imageBase64.Split(',')[1]);
    }

    private static string GetImageContentType(string imageBase64)
    {
        return imageBase64.Split(',')[0].Split(':')[1].Split(';')[0];
    }

    public static string GenerateNameWithExtension(string imageBase64)
    {
        var timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd_HH-mm-ss");
        var name = $"{timestamp}_{Path.GetRandomFileName()}";
        return Path.ChangeExtension(name, GetImageExtension(imageBase64));
    }

    private static string GetImageExtension(string imageBase64)
    {
        return imageBase64.Split(';')[0].Split('/')[1];
    }
    /* -------------------- Validation Helpers -------------------- */

    public class ImageValidator : AbstractValidator<IBrowserFile>
    {
        public ImageValidator(IStringLocalizer<ValidationMessage> localizer)
        {
            RuleFor(x => x.Size)
                .LessThanOrEqualTo(ImageConsts.MaxFileSize)
                .WithMessage(x
                    => localizer[nameof(ValidationMessageString.ImageMaximumFileSize), ImageConsts.MaxFileSize]);

            RuleFor(x => x.ContentType)
                .Must(x => ImageConsts.AllowedFileTypes.Contains(x))
                .WithMessage(x => localizer[nameof(ValidationMessageString.ImageAllowedFileTypes),
                    MakeAllowedFileTypesString(ImageConsts.AllowedFileTypes)]);
        }
    }
}