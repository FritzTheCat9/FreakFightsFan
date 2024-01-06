﻿using FluentValidation;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Emails;
using FreakFightsFan.Api.Emails.Templates;
using FreakFightsFan.Shared.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FreakFightsFan.Api.Features.Users.Commands
{
    public static class ConfirmEmail
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

        public class Handler : IRequestHandler<Command, bool>
        {
            private readonly IUserRepository _userRepository;
            private readonly IEmailService _emailService;

            public Handler(IUserRepository userRepository, IEmailService emailService)
            {
                _userRepository = userRepository;
                _emailService = emailService;
            }

            public async Task<bool> Handle(Command command, CancellationToken cancellationToken)
            {
                var user = await _userRepository.GetByEmail(command.Email) ??
                    throw new MyValidationException("Email", "User with given 'Email' does not exist");

                if (user.EmailConfirmed)
                    throw new MyValidationException("Email", "Provided 'Email' has already been confirmed");

                var isTokenAssignedToUser = await _userRepository.IsTokenAssignedToUser(user.Email, command.Token);
                if (!isTokenAssignedToUser)
                    throw new MyValidationException("Token", "Provided 'Token' is not assigned to this user");

                user.EmailConfirmed = true;
                user.EmailConfirmationToken = null;

                await _userRepository.Update(user);

                await _emailService.SendEmail(user.Email, new EmailConfirmationSuccessfulTemplateModel
                {
                    UserName  = user.UserName,
                });

                return isTokenAssignedToUser;
            }
        }

        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapGet("/api/users/confirmEmail", async (
                [FromQuery(Name = "email")] string email,
                [FromQuery(Name = "token")] string token,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var command = new Command()
                {
                    Email = email,
                    Token = token,
                };

                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
                .WithTags("Users")
                .AllowAnonymous();

            return app;
        }
    }
}
