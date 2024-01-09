using FluentValidation;
using FreakFightsFan.Shared.Features.Images.Helpers;
using MediatR;

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

            public Validator()
            {
                _allowedFileTypesString = ImageHelpers.MakeAllowedFileTypesString(ImageConsts.AllowedFileTypes);

                RuleFor(x => x.ImageBase64)
                    .NotEmpty()
                    .Must(x => ImageHelpers.HaveValidSize(x, ImageConsts.MaxFileSize))
                        .WithMessage($"The maximum file size is {ImageConsts.MaxFileSize} bytes")
                    .Must(x => ImageHelpers.HaveValidFileType(x, ImageConsts.AllowedFileTypes))
                        .WithMessage($"Allowed image types: {_allowedFileTypesString}");
            }
        }
    }
}
