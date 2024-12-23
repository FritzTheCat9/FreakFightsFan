﻿using FluentValidation;
using FreakFightsFan.Shared.Localization;
using MediatR;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Shared.Features.Users.Commands;

public class Register
{
    public class Command : IRequest<int>
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
    }

    public class Validator : AbstractValidator<Command>
    {
        public Validator(IStringLocalizer<ValidationMessage> localizer)
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage(x => localizer[nameof(ValidationMessageString.EmailNotEmpty)])
                .MaximumLength(ValidationConsts.MaximumStringLength)
                .WithMessage(x => localizer[nameof(ValidationMessageString.EmailMaximumLength)])
                .EmailAddress()
                .WithMessage(x => localizer[nameof(ValidationMessageString.EmailIsEmailAddress)]);

            RuleFor(x => x.UserName)
                .NotEmpty()
                .WithMessage(x => localizer[nameof(ValidationMessageString.UserNameNotEmpty)])
                .MinimumLength(ValidationConsts.MinimumStringLength)
                .WithMessage(x => localizer[nameof(ValidationMessageString.UserNameMinimumLength)])
                .MaximumLength(ValidationConsts.MaximumStringLength)
                .WithMessage(x => localizer[nameof(ValidationMessageString.UserNameMaximumLength)])
                .Matches(ValidationConsts.UserNameRegex)
                .WithMessage(x => localizer[nameof(ValidationMessageString.UserNameMatchesRegex)]);

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage(x => localizer[nameof(ValidationMessageString.PasswordNotEmpty)])
                .MinimumLength(ValidationConsts.MinimumStringLength)
                .WithMessage(x => localizer[nameof(ValidationMessageString.PasswordMinimumLength)]);

            RuleFor(x => x.RepeatPassword)
                .NotEmpty()
                .WithMessage(x => localizer[nameof(ValidationMessageString.PasswordNotEmpty)])
                .MinimumLength(ValidationConsts.MinimumStringLength)
                .WithMessage(x => localizer[nameof(ValidationMessageString.PasswordMinimumLength)])
                .Equal(x => x.Password)
                .WithMessage(x => localizer[nameof(ValidationMessageString.RepeatPasswordEqualPassword)]);
        }
    }
}