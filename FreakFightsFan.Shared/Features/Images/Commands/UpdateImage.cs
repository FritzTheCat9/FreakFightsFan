using FluentValidation;
using FreakFightsFan.Shared.Features.Images.Helpers;
using FreakFightsFan.Shared.Localization;
using MediatR;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Shared.Features.Images.Commands;

public static class UpdateImage
{
    public class Command : IRequest<Unit>
    {
        public int Id { get; set; }
        public string ImageBase64 { get; set; }
    }

    public class Validator : AbstractValidator<Command>
    {
        public Validator(IStringLocalizer<ValidationMessage> localizer)
        {
            RuleFor(x => x.ImageBase64)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage(x => localizer[nameof(ValidationMessageString.ImageNotEmpty)])
                .Must(x => ImageHelpers.HaveValidSize(x, ImageConsts.MaxFileSize))
                .WithMessage(x
                    => localizer[nameof(ValidationMessageString.ImageMaximumFileSize), ImageConsts.MaxFileSize])
                .Must(x => ImageHelpers.HaveValidFileType(x, ImageConsts.AllowedFileTypes))
                .WithMessage(x
                    => localizer[nameof(ValidationMessageString.ImageAllowedFileTypes),
                        ImageHelpers.MakeAllowedFileTypesString(ImageConsts.AllowedFileTypes)]);
        }
    }

    public class FormModel : Command
    {
        public IBrowserFile File { get; set; }
    }

    public class FormModelValidator : AbstractValidator<FormModel>
    {
        public FormModelValidator(IStringLocalizer<ValidationMessage> localizer)
        {
            RuleFor(x => x.ImageBase64)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage(x => localizer[nameof(ValidationMessageString.ImageNotEmpty)])
                .Must(x => ImageHelpers.HaveValidSize(x, ImageConsts.MaxFileSize))
                .WithMessage(x
                    => localizer[nameof(ValidationMessageString.ImageMaximumFileSize), ImageConsts.MaxFileSize])
                .Must(x => ImageHelpers.HaveValidFileType(x, ImageConsts.AllowedFileTypes))
                .WithMessage(x
                    => localizer[nameof(ValidationMessageString.ImageAllowedFileTypes),
                        ImageHelpers.MakeAllowedFileTypesString(ImageConsts.AllowedFileTypes)]);

            RuleFor(x => x.File)
                .SetValidator(new ImageHelpers.ImageValidator(localizer));
        }
    }
}