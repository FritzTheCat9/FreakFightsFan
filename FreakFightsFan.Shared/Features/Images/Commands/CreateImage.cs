using FluentValidation;
using FreakFightsFan.Shared.Features.Images.Helpers;
using FreakFightsFan.Shared.Localization;
using MediatR;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Shared.Features.Images.Commands
{
    public class CreateImage
    {
        public class Command : IRequest<int>
        {
            public string ImageBase64 { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            private readonly string _allowedFileTypesString;

            public Validator(IStringLocalizer<ValidationMessage> localizer)
            {
                _allowedFileTypesString = ImageHelpers.MakeAllowedFileTypesString(ImageConsts.AllowedFileTypes);

                RuleFor(x => x.ImageBase64)
                    .NotEmpty()
                    .WithMessage(x => localizer[nameof(ValidationMessageString.ImageNotEmpty)])
                    .Must(x => ImageHelpers.HaveValidSize(x, ImageConsts.MaxFileSize))
                    .WithMessage(x => localizer[nameof(ValidationMessageString.ImageMaximumFileSize), ImageConsts.MaxFileSize])
                    .Must(x => ImageHelpers.HaveValidFileType(x, ImageConsts.AllowedFileTypes))
                    .WithMessage(x => localizer[nameof(ValidationMessageString.ImageAllowedFileTypes), _allowedFileTypesString]);
            }
        }
    }
}
