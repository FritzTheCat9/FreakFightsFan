using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Auth;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Emails;
using FreakFightsFan.Api.Emails.Templates;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Users.Commands;
using MediatR;

namespace FreakFightsFan.Api.Features.Users.Commands
{
    public static class RegisterFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/users/register", async (
                Register.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                int userId = await mediator.Send(command, cancellationToken);
                return Results.CreatedAtRoute("GetUser", new { id = userId });
            })
                .WithTags("Users")
                .AllowAnonymous();

            return app;
        }

        public class Handler : IRequestHandler<Register.Command, int>
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

            public async Task<int> Handle(Register.Command command, CancellationToken cancellationToken)
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

            private async Task ValidateCommand(Register.Command command)
            {
                var emailExists = await _userRepository.EmailExists(command.Email);
                if (emailExists)
                    throw new MyValidationException($"{nameof(command.Email)}", $"{nameof(command.Email)} is already taken");

                var userNameExists = await _userRepository.UserNameExists(command.UserName);
                if (userNameExists)
                    throw new MyValidationException($"{nameof(command.UserName)}", $"{nameof(command.UserName)} is already taken");
            }
        }
    }
}
