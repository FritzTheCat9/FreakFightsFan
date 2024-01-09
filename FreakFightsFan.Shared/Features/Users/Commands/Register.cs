using FluentValidation;
using MediatR;

namespace FreakFightsFan.Shared.Features.Users.Commands
{
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
            public Validator()
            {
                RuleFor(x => x.Email)
                    .NotEmpty()
                    .EmailAddress();

                RuleFor(x => x.UserName)
                    .NotEmpty()
                    .MinimumLength(7)
                    .MaximumLength(30)
                    .Matches("^[a-zA-Z0-9_]+$")
                        .WithMessage("UserName can contain only: a-z, A-Z, 0-9 and _ characters");

                RuleFor(x => x.Password)
                    .NotEmpty()
                    .MinimumLength(7);

                RuleFor(x => x.RepeatPassword)
                    .NotEmpty()
                    .MinimumLength(7)
                    .Equal(x => x.Password)
                        .WithMessage("The passwords entered must match");
            }
        }
    }
}
