﻿using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Emails;
using FreakFightsFan.Api.Emails.Templates;
using FreakFightsFan.Api.Localization;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Users.Commands;
using MediatR;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Api.Features.Users.Commands
{
    public static class ConfirmEmailFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/users/confirmEmail", async (ConfirmEmail.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
                .WithTags("Users")
                .AllowAnonymous();

            return app;
        }

        public class Handler : IRequestHandler<ConfirmEmail.Command, bool>
        {
            private readonly IUserRepository _userRepository;
            private readonly IEmailService _emailService;
            private readonly IStringLocalizer<ApiValidationMessage> _localizer;

            public Handler(IUserRepository userRepository, IEmailService emailService, IStringLocalizer<ApiValidationMessage> localizer)
            {
                _userRepository = userRepository;
                _emailService = emailService;
                _localizer = localizer;
            }

            public async Task<bool> Handle(ConfirmEmail.Command command, CancellationToken cancellationToken)
            {
                var user = await _userRepository.GetByEmail(command.Email) ??
                    throw new MyValidationException(nameof(ConfirmEmail.Command.Email),
                        _localizer[nameof(ApiValidationMessageString.EmailUserWithGivenEmailDoesNotExist)]);

                if (user.EmailConfirmed)
                    throw new MyValidationException(nameof(ConfirmEmail.Command.Email),
                        _localizer[nameof(ApiValidationMessageString.EmailAlreadyConfirmed)]);

                var isTokenAssignedToUser = await _userRepository.IsTokenAssignedToUser(user.Email, command.Token);
                if (!isTokenAssignedToUser)
                    throw new MyValidationException(nameof(ConfirmEmail.Command.Token),
                        _localizer[nameof(ApiValidationMessageString.TokenIsNotAssignedToThisUser)]);

                user.EmailConfirmed = true;
                user.EmailConfirmationToken = null;

                await _userRepository.Update(user);

                await _emailService.SendEmail(user.Email, new EmailConfirmationSuccessfulTemplateModel
                {
                    UserName = user.UserName,
                });

                return isTokenAssignedToUser;
            }
        }
    }
}
