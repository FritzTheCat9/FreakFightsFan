using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Auth;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Emails;
using FreakFightsFan.Api.Emails.Templates;
using FreakFightsFan.Api.Features.Users.Extensions;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Users.Requests;
using MediatR;

namespace FreakFightsFan.Api.Features.Users.Commands
{
    public static class Register
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

        public class Handler : IRequestHandler<Command, int>
        {
            private readonly IClock _clock;
            private readonly IPasswordService _passwordService;
            private readonly IUserRepository _userRepository;
            private readonly IEmailService _emailService;
            private readonly IEmailConfirmationService _emailConfirmationService;

            public Handler(IClock clock, IPasswordService passwordService, IUserRepository userRepository, 
                IEmailService emailService, IEmailConfirmationService emailConfirmationService)
            {
                _clock = clock;
                _passwordService = passwordService;
                _userRepository = userRepository;
                _emailService = emailService;
                _emailConfirmationService = emailConfirmationService;
            }

            public async Task<int> Handle(Command command, CancellationToken cancellationToken)
            {
                await ValidateCommand(command);

                var user = new User
                {
                    Id = 0,
                    Created = _clock.Current(),
                    Modified = _clock.Current(),
                    Email = command.Email,
                    UserName = command.UserName,
                    Password = _passwordService.Hash(command.Password),
                    EmailConfirmed = false,
                    EmailConfirmationToken = _emailConfirmationService.GenerateEmailConfirmationToken(command.Email),
                    IsAdmin = false,
                    IsSuperAdmin = false,
                };

                var userId = await _userRepository.Create(user);

                await _emailService.SendEmail(user.Email, new EmailConfirmationTemplateModel
                {
                    UserName = command.UserName,
                    Link = _emailConfirmationService.GenerateConfirmationLink(user.Email, user.EmailConfirmationToken),
                });

                return userId;
            }

            private async Task ValidateCommand(Command command)
            {
                var emailExists = await _userRepository.EmailExists(command.Email);
                if (emailExists)
                    throw new MyValidationException("Email", "'Email' is already taken");

                var userNameExists = await _userRepository.UserNameExists(command.UserName);
                if (userNameExists)
                    throw new MyValidationException("UserName", "'UserName' is already taken");
            }
        }

        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/users/register", async (
                RegisterRequest request,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                int userId = await mediator.Send(request.ToRegisterCommand(), cancellationToken);
                return Results.CreatedAtRoute("GetUser", new { id = userId });
            })
                .WithTags("Users")
                .AllowAnonymous();

            return app;
        }
    }
}
