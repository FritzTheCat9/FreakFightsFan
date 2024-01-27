using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Auth;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Users.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Users.Commands
{
    public static class UpdateUserFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPut("/api/users/{id}", async (
                int id,
                UpdateUser.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                command.Id = id;
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
                .WithTags("Users")
                .RequireAuthorization(Policy.User);

            return app;
        }

        public class Handler : IRequestHandler<UpdateUser.Command, Unit>
        {
            private readonly IUserRepository _userRepository;
            private readonly IClock _clock;
            private readonly IImageService _imageService;
            private readonly IAuthService _authService;

            public Handler(
                IUserRepository userRepository,
                IClock clock,
                IImageService imageService,
                IAuthService authService)
            {
                _userRepository = userRepository;
                _clock = clock;
                _imageService = imageService;
                _authService = authService;
            }

            public async Task<Unit> Handle(
                UpdateUser.Command command,
                CancellationToken cancellationToken)
            {
                var user = await _userRepository.Get(command.Id) ?? throw new MyNotFoundException();

                // TODO: dodać to ok ok 

                // validacja czy my to user bo swoje zdjęcie można zmieniać (ale admin też może i super admin)
                // albo czy user to identity user albo czy mamy role admin lub super admin

                //var validRole = _authService.IsInAnyRole(Role.Admin, Role.SuperAdmin);
                //var isProfileOwner = _authService.User.Identity.id ???

                //user.Modified = _clock.Current();
                //user.Image = _imageService.UpdateEntityImage(user.Image, command.ImageBase64);

                await _userRepository.Update(user);
                return Unit.Value;
            }
        }
    }
}