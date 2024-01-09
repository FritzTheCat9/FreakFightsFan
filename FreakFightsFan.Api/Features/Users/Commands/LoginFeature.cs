using FreakFightsFan.Api.Auth;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Users.Commands;
using FreakFightsFan.Shared.Features.Users.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Users.Commands
{
    public static class LoginFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/users/login", async (
                Login.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
                .WithTags("Users")
                .AllowAnonymous();

            return app;
        }

        public class Handler : IRequestHandler<Login.Command, JwtDto>
        {
            private readonly IPasswordService _passwordService;
            private readonly IUserRepository _userRepository;
            private readonly IAuthenticator _authenticator;

            public Handler(IPasswordService passwordService, IUserRepository userRepository, IAuthenticator authenticator)
            {
                _passwordService = passwordService;
                _userRepository = userRepository;
                _authenticator = authenticator;
            }

            public async Task<JwtDto> Handle(Login.Command command, CancellationToken cancellationToken)
            {
                var user = await _userRepository.GetByEmail(command.Email) ?? 
                    throw new MyValidationException("Email", "User with given 'Email' does not exist");

                if (!user.EmailConfirmed)
                    throw new MyValidationException("Email", "'Email' is not confirmed");

                if (!_passwordService.Validate(command.Password, user.Password))
                    throw new MyValidationException("Password", "Incorrect 'Password'");

                var jwt = _authenticator.CreateToken(user);

                return jwt;
            }
        }
    }
}
