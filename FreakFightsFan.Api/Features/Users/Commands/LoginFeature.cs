using FreakFightsFan.Api.Auth;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Api.Localization;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Users.Commands;
using FreakFightsFan.Shared.Features.Users.Responses;
using MediatR;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Api.Features.Users.Commands;

public static class LoginFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapPost("/api/users/login", async (
                Login.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
            .WithTags(Tags.Users)
            .AllowAnonymous();
    }

    public class Handler(
        IPasswordService passwordService,
        IUserRepository userRepository,
        IAuthenticator authenticator,
        IStringLocalizer<ApiValidationMessage> localizer)
        : IRequestHandler<Login.Command, JwtDto>
    {
        public async Task<JwtDto> Handle(Login.Command command, CancellationToken cancellationToken)
        {
            var user = await userRepository.GetByEmail(command.Email) ??
                       throw new MyValidationException(nameof(Login.Command.Email),
                           localizer[nameof(ApiValidationMessageString.EmailUserWithGivenEmailDoesNotExist)]);

            if (!user.EmailConfirmed)
            {
                throw new MyValidationException(nameof(Login.Command.Email),
                    localizer[nameof(ApiValidationMessageString.EmailIsNotConfirmed)]);
            }

            if (!passwordService.Validate(command.Password, user.Password))
            {
                throw new MyValidationException(nameof(Login.Command.Password),
                    localizer[nameof(ApiValidationMessageString.PasswordIsIncorrect)]);
            }

            var jwt = authenticator.CreateTokens(user);

            user.RefreshToken = jwt.RefreshToken;
            await userRepository.Update(user);

            return jwt;
        }
    }
}