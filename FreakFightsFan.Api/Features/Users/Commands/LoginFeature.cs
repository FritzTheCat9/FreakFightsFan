﻿using FreakFightsFan.Api.Auth;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Api.Localization;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Users.Commands;
using FreakFightsFan.Shared.Features.Users.Responses;
using MediatR;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Api.Features.Users.Commands
{
    public static class LoginFeature
    {
        public static void Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/users/login", async (
                        Login.Command command,
                        IMediator mediator,
                        CancellationToken cancellationToken)
                    => Results.Ok(await mediator.Send(command, cancellationToken)))
                .WithTags(Tags.Users)
                .AllowAnonymous();
        }

        public class Handler : IRequestHandler<Login.Command, JwtDto>
        {
            private readonly IPasswordService _passwordService;
            private readonly IUserRepository _userRepository;
            private readonly IAuthenticator _authenticator;
            private readonly IStringLocalizer<ApiValidationMessage> _localizer;

            public Handler(
                IPasswordService passwordService,
                IUserRepository userRepository,
                IAuthenticator authenticator,
                IStringLocalizer<ApiValidationMessage> localizer)
            {
                _passwordService = passwordService;
                _userRepository = userRepository;
                _authenticator = authenticator;
                _localizer = localizer;
            }

            public async Task<JwtDto> Handle(Login.Command command, CancellationToken cancellationToken)
            {
                var user = await _userRepository.GetByEmail(command.Email) ??
                           throw new MyValidationException(nameof(Login.Command.Email),
                               _localizer[nameof(ApiValidationMessageString.EmailUserWithGivenEmailDoesNotExist)]);

                if (!user.EmailConfirmed)
                    throw new MyValidationException(nameof(Login.Command.Email),
                        _localizer[nameof(ApiValidationMessageString.EmailIsNotConfirmed)]);

                if (!_passwordService.Validate(command.Password, user.Password))
                    throw new MyValidationException(nameof(Login.Command.Password),
                        _localizer[nameof(ApiValidationMessageString.PasswordIsIncorrect)]);

                var jwt = _authenticator.CreateTokens(user);

                user.RefreshToken = jwt.RefreshToken;
                await _userRepository.Update(user);

                return jwt;
            }
        }
    }
}