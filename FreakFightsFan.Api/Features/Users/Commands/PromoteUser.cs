using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Users.Commands
{
    public static class PromoteUser
    {
        public class Command : IRequest<Unit>
        {
            public int Id { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator()
            {
                
            }
        }

        public class Handler : IRequestHandler<Command, Unit>
        {
            private readonly IUserRepository _userRepository;
            private readonly IClock _clock;

            public Handler(IUserRepository userRepository, IClock clock)
            {
                _userRepository = userRepository;
                _clock = clock;
            }

            public async Task<Unit> Handle(Command command, CancellationToken cancellationToken)
            {
                var user = await _userRepository.Get(command.Id) ?? throw new MyNotFoundException();

                user.Modified = _clock.Current();
                user.IsAdmin = true;

                await _userRepository.Update(user);
                return Unit.Value;
            }
        }

        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPut("/api/users/promote/{id}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var command = new Command { Id = id };
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
                .WithTags("Users")
                .RequireAuthorization(Policy.SuperAdmin);

            return app;
        }
    }
}
