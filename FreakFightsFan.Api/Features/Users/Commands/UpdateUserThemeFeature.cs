using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Auth;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Users.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Users.Commands
{
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

        public class Handler : IRequestHandler<UpdateUserTheme.Command, Unit>
        {
            private readonly IUserRepository _userRepository;
            private readonly IAuthService _authService;
            private readonly IClock _clock;

            public Handler(
                IUserRepository userRepository,
                IAuthService authService,
                IClock clock)
            {
                _userRepository = userRepository;
                _authService = authService;
                _clock = clock;
            }

            public async Task<Unit> Handle(
                UpdateUserTheme.Command command,
                CancellationToken cancellationToken)
            {
                var isLoggedInUser = _authService.IsLoggedInUser(command.Id);
                if (!isLoggedInUser)
                    throw new MyForbiddenException();

                var user = await _userRepository.Get(command.Id) ?? throw new MyNotFoundException();

                user.ThemeColor = command.ThemeColor;
                user.Modified = _clock.Current();

                await _userRepository.Update(user);
                return Unit.Value;
            }
        }
    }
}