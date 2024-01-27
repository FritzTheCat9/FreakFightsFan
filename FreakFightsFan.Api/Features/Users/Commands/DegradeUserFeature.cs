using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Users.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Users.Commands
{
    public static class DegradeUserFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPut("/api/users/degrade/{id}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var command = new DegradeUser.Command { Id = id };
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
                .WithTags("Users")
                .RequireAuthorization(Policy.SuperAdmin);

            return app;
        }

        public class Handler : IRequestHandler<DegradeUser.Command, Unit>
        {
            private readonly IUserRepository _userRepository;
            private readonly IClock _clock;

            public Handler(
                IUserRepository userRepository,
                IClock clock)
            {
                _userRepository = userRepository;
                _clock = clock;
            }

            public async Task<Unit> Handle(
                DegradeUser.Command command,
                CancellationToken cancellationToken)
            {
                var user = await _userRepository.Get(command.Id) ?? throw new MyNotFoundException();

                user.Modified = _clock.Current();
                user.IsAdmin = false;

                await _userRepository.Update(user);
                return Unit.Value;
            }
        }
    }
}
