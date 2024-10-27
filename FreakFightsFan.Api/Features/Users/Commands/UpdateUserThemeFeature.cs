using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Auth;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Users.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Users.Commands;

public static class UpdateUserThemeFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapPut("/api/users/{id:int}/theme", async (
                int id,
                UpdateUserTheme.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                command.Id = id;
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
            .WithTags(Tags.Users)
            .RequireAuthorization(Policy.User);
    }

    public class Handler(
        IUserRepository userRepository,
        IAuthService authService,
        IClock clock)
        : IRequestHandler<UpdateUserTheme.Command, Unit>
    {
        public async Task<Unit> Handle(
            UpdateUserTheme.Command command,
            CancellationToken cancellationToken)
        {
            var isLoggedInUser = authService.IsLoggedInUser(command.Id);
            if (!isLoggedInUser)
            {
                throw new MyForbiddenException();
            }

            var user = await userRepository.Get(command.Id) ?? throw new MyNotFoundException();

            user.ThemeColor = command.ThemeColor;
            user.Modified = clock.Current();

            await userRepository.Update(user);
            return Unit.Value;
        }
    }
}