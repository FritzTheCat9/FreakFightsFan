using FreakFightsFan.Api.Auth;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Api.Localization;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Users.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using FreakFightsFan.Shared.Features.Users.Responses;
using MediatR;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Api.Features.Users.Commands;

public static class RefreshTokenFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapPost("/api/users/refresh-token", async (
                RefreshToken.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
            .WithTags(Tags.Users)
            .RequireAuthorization(Policy.User);
    }

    public class Handler(
        IAuthService authService,
        IUserRepository userRepository,
        IAuthenticator authenticator,
        IStringLocalizer<ApiValidationMessage> localizer)
        : IRequestHandler<RefreshToken.Command, JwtDto>
    {
        public async Task<JwtDto> Handle(RefreshToken.Command command, CancellationToken cancellationToken)
        {
            var currentUserId = authService.GetCurrentUserId() ?? throw new MyForbiddenException();
            var user = await userRepository.Get(currentUserId) ?? throw new MyNotFoundException();

            if (!user.EmailConfirmed)
            {
                throw new MyValidationException(nameof(Login.Command.Email),
                    localizer[nameof(ApiValidationMessageString.EmailIsNotConfirmed)]);
            }

            if (user.RefreshToken != command.RefreshToken)
            {
                throw new MyValidationException(nameof(RefreshToken.Command.RefreshToken),
                    localizer[nameof(ApiValidationMessageString.RefreshTokenIsNotValid)]);
            }

            var jwt = authenticator.CreateTokens(user);

            user.RefreshToken = jwt.RefreshToken;
            await userRepository.Update(user);

            return jwt;
        }
    }
}