using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Users.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Users.Commands;

public static class DegradeUserFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapPut("/api/users/degrade/{id:int}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var command = new DegradeUser.Command { Id = id };
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
            .WithTags(Tags.Users)
            .RequireAuthorization(Policy.SuperAdmin);
    }

    public class Handler(
        IUserRepository userRepository,
        IClock clock) : IRequestHandler<DegradeUser.Command, Unit>
    {
        public async Task<Unit> Handle(
            DegradeUser.Command command,
            CancellationToken cancellationToken)
        {
            var user = await userRepository.Get(command.Id) ?? throw new MyNotFoundException();

            user.Modified = clock.Current();
            user.IsAdmin = false;

            await userRepository.Update(user);
            return Unit.Value;
        }
    }
}