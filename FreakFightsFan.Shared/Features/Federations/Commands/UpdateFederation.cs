using FluentValidation;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Images.Helpers;
using MediatR;

namespace FreakFightsFan.Shared.Features.Federations.Commands
{
    public class UpdateFederation
    {
        public class Command : IRequest<Unit>
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string ImageBase64 { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            private readonly string _allowedFileTypesString;

            public Validator()
            {
                _allowedFileTypesString = ImageHelpers.MakeAllowedFileTypesString(ImageConsts.AllowedFileTypes);

                RuleFor(x => x.Name)
                    .NotEmpty();

                When(x => !string.IsNullOrWhiteSpace(x.ImageBase64), () =>
                {
                    RuleFor(x => x.ImageBase64)
                        .NotEmpty()
                        .WithMessage(x => ValidationMessages.NotEmpty("Image"))
                        .Must(x => ImageHelpers.HaveValidSize(x, ImageConsts.MaxFileSize))
                            .WithMessage($"The maximum file size is {ImageConsts.MaxFileSize} bytes")
                        .Must(x => ImageHelpers.HaveValidFileType(x, ImageConsts.AllowedFileTypes))
                            .WithMessage($"Allowed image types: {_allowedFileTypesString}");
                });
            }
        }
    }
}
