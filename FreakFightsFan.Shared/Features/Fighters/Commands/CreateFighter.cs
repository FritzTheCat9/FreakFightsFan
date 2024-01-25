using FluentValidation;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Images.Helpers;
using MediatR;

namespace FreakFightsFan.Shared.Features.Fighters.Commands
{
    public class CreateFighter
    {
        public class Command : IRequest<int>
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Nickname { get; set; }
            public string InstagramUrl { get; set; }
            public string ImageBase64 { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            private readonly string _allowedFileTypesString;

            public Validator()
            {
                _allowedFileTypesString = ImageHelpers.MakeAllowedFileTypesString(ImageConsts.AllowedFileTypes);

                RuleFor(x => x.FirstName)
                    .NotEmpty()
                    .WithMessage(x => ValidationMessages.NotEmpty("First name"));

                RuleFor(x => x.LastName)
                    .NotEmpty()
                    .WithMessage(x => ValidationMessages.NotEmpty("Last name"));

                RuleFor(x => x.Nickname)
                    .NotEmpty()
                    .WithMessage(x => ValidationMessages.NotEmpty($"{nameof(x.Nickname)}"));

                When(x => !string.IsNullOrWhiteSpace(x.InstagramUrl), () =>
                {
                    RuleFor(x => x.InstagramUrl)
                        .NotEmpty()
                        .WithMessage(x => ValidationMessages.NotEmpty("Instagram Url"))
                        .Matches("^(?:https?:\\/\\/)?(?:www\\.)?instagram\\.com\\/([a-zA-Z0-9_\\.]{1,30})\\/?$")
                        .WithMessage("This is not a valid link to the Instagram profile");
                });

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
