﻿using FluentValidation;
using FreakFightsFan.Shared.Features.Images.Helpers;
using FreakFightsFan.Shared.Localization;
using MediatR;
using Microsoft.Extensions.Localization;

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

            public Validator(IStringLocalizer<ValidationMessage> localizer)
            {
                _allowedFileTypesString = ImageHelpers.MakeAllowedFileTypesString(ImageConsts.AllowedFileTypes);

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
