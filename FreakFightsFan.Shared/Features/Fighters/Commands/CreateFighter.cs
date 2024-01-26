﻿using FluentValidation;
using FreakFightsFan.Shared.Features.Images.Helpers;
using FreakFightsFan.Shared.Localization;
using MediatR;
using Microsoft.Extensions.Localization;

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

            public Validator(IStringLocalizer<ValidationMessage> localizer)
            {
                _allowedFileTypesString = ImageHelpers.MakeAllowedFileTypesString(ImageConsts.AllowedFileTypes);

                RuleFor(x => x.FirstName)
                    .NotEmpty()
                    .WithMessage(x => localizer[nameof(ValidationMessageString.FirstNameNotEmpty)])
                    .MaximumLength(ValidationConsts.MaximumStringLength)
                    .WithMessage(x => localizer[nameof(ValidationMessageString.FirstNameMaximumLength)]);

                RuleFor(x => x.LastName)
                    .NotEmpty()
                    .WithMessage(x => localizer[nameof(ValidationMessageString.LastNameNotEmpty)])
                    .MaximumLength(ValidationConsts.MaximumStringLength)
                    .WithMessage(x => localizer[nameof(ValidationMessageString.LastNameMaximumLength)]);

                RuleFor(x => x.Nickname)
                    .NotEmpty()
                    .WithMessage(x => localizer[nameof(ValidationMessageString.NicknameNotEmpty)])
                    .MaximumLength(ValidationConsts.MaximumStringLength)
                    .WithMessage(x => localizer[nameof(ValidationMessageString.NicknameMaximumLength)]);

                When(x => !string.IsNullOrWhiteSpace(x.InstagramUrl), () =>
                {
                    RuleFor(x => x.InstagramUrl)
                        .NotEmpty()
                        .WithMessage(x => localizer[nameof(ValidationMessageString.InstagramUrlNotEmpty)])
                        .Matches(ValidationConsts.InstagramUrlRegex)
                        .WithMessage(x => localizer[nameof(ValidationMessageString.InstagramUrlMatchesRegex)]);
                });

                When(x => !string.IsNullOrWhiteSpace(x.ImageBase64), () =>
                {
                    RuleFor(x => x.ImageBase64)
                        .NotEmpty()
                        .WithMessage(x => localizer[nameof(ValidationMessageString.ImageNotEmpty)])
                        .Must(x => ImageHelpers.HaveValidSize(x, ImageConsts.MaxFileSize))
                        .WithMessage(x => localizer[nameof(ValidationMessageString.ImageMaximumFileSize), ImageConsts.MaxFileSize])
                        .Must(x => ImageHelpers.HaveValidFileType(x, ImageConsts.AllowedFileTypes))
                        .WithMessage(x => localizer[nameof(ValidationMessageString.ImageAllowedFileTypes), _allowedFileTypesString]);
                });
            }
        }
    }
}
