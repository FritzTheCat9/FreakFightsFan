using FluentValidation;
using FreakFightsFan.Shared.Features.Users.Responses;
using FreakFightsFan.Shared.Localization;
using MediatR;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Shared.Features.Users.Commands;

public static class Login
{
    public class Command : IRequest<JwtDto>
    {
        public string Email { get; set; }
        public string Password { get; set; }
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

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage(x => localizer[nameof(ValidationMessageString.PasswordNotEmpty)])
                .MinimumLength(ValidationConsts.MinimumStringLength)
                .WithMessage(x => localizer[nameof(ValidationMessageString.PasswordMinimumLength)])
                .MaximumLength(ValidationConsts.MaximumStringLength)
                .WithMessage(x => localizer[nameof(ValidationMessageString.PasswordMaximumLength)]);
        }
    }
}