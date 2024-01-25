using FluentValidation;
using FreakFightsFan.Shared.Features.Images.Helpers;
using MediatR;

namespace FreakFightsFan.Shared.Features.Users.Commands
{
    public class UpdateUser
    {
        public class Command : IRequest<Unit>
        {
            public int Id { get; set; }
            public string ImageBase64 { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            private readonly string _allowedFileTypesString;

            public Validator()
            {
                _allowedFileTypesString = ImageHelpers.MakeAllowedFileTypesString(ImageConsts.AllowedFileTypes);

                When(x => !string.IsNullOrWhiteSpace(x.ImageBase64), () =>
                {
                    RuleFor(x => x.ImageBase64)
                        .NotEmpty()
                        .Must(x => ImageHelpers.HaveValidSize(x, ImageConsts.MaxFileSize))
                            .WithMessage($"The maximum file size is {ImageConsts.MaxFileSize} bytes")
                        .Must(x => ImageHelpers.HaveValidFileType(x, ImageConsts.AllowedFileTypes))
                            .WithMessage($"Allowed image types: {_allowedFileTypesString}");
                });
            }
        }
    }
}
