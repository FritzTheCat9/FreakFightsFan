using FluentValidation;
using MediatR;

namespace FreakFightsFan.Shared.Features.Users.Commands
{
    public class ConfirmEmail
    {
        public class Command : IRequest<bool>
        {
            public string Email { get; set; }
            public string Token { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator()
            {
                RuleFor(x => x.Email)
                    .NotEmpty()
                    .EmailAddress();

                RuleFor(x => x.Token)
                    .NotEmpty();
            }
        }
    }
}
