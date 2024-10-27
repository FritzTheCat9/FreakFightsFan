using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Auth;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Emails;
using FreakFightsFan.Api.Emails.Models;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Api.Localization;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Users.Commands;
using MediatR;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Api.Features.Users.Commands;

public static class RegisterFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapPost("/api/users/register", async (
                Register.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var userId = await mediator.Send(command, cancellationToken);
                return Results.CreatedAtRoute("GetUser", new { id = userId });
            })
            .WithTags(Tags.Users)
            .AllowAnonymous();
    }

    public class Handler(
        IClock clock,
        IPasswordService passwordService,
        IUserRepository userRepository,
        IEmailService emailService,
        IEmailConfirmationService emailConfirmationService,
        IStringLocalizer<ApiValidationMessage> validationLocalizer,
        IStringLocalizer<EmailTranslation> emailLocalizer)
        : IRequestHandler<Register.Command, int>
    {
        public async Task<int> Handle(
            Register.Command command,
            CancellationToken cancellationToken)
        {
            await ValidateCommand(command);

            var user = new User
            {
                Id = 0,
                Created = clock.Current(),
                Modified = clock.Current(),
                Email = command.Email,
                UserName = command.UserName,
                Password = passwordService.Hash(command.Password),
                EmailConfirmed = false,
                EmailConfirmationToken = emailConfirmationService.GenerateEmailConfirmationToken(command.Email),
                IsAdmin = false,
                IsSuperAdmin = false,
            };

            var userId = await userRepository.Create(user);

            await emailService.SendEmail(user.Email,
                new EmailConfirmationTemplateModel(emailLocalizer)
                {
                    UserName = command.UserName,
                    Link = emailConfirmationService.GenerateConfirmationLink(user.Email,
                        user.EmailConfirmationToken),
                });

            return userId;
        }

        private async Task ValidateCommand(Register.Command command)
        {
            var emailExists = await userRepository.EmailExists(command.Email);
            if (emailExists)
            {
                throw new MyValidationException(nameof(Register.Command.Email),
                    validationLocalizer[nameof(ApiValidationMessageString.EmailIsAlreadyTaken)]);
            }

            var userNameExists = await userRepository.UserNameExists(command.UserName);
            if (userNameExists)
            {
                throw new MyValidationException(nameof(Register.Command.UserName),
                    validationLocalizer[nameof(ApiValidationMessageString.UserNameIsAlreadyTaken)]);
            }
        }
    }
}