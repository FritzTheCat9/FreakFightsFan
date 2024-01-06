using FluentValidation;
using FreakFightsFan.Api.Auth;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Users.Extensions;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Users.Requests;
using FreakFightsFan.Shared.Features.Users.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Users.Commands
{
    public static class Login
    {
        public class Command : IRequest<JwtDto>
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator()
            {
                RuleFor(x => x.Email)
                    .NotEmpty()
                    .EmailAddress();

                RuleFor(x => x.Password)
                    .NotEmpty()
                    .MinimumLength(7);
            }
        }

        public class Handler : IRequestHandler<Command, JwtDto>
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

            public async Task<JwtDto> Handle(Command command, CancellationToken cancellationToken)
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

        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/users/login", async (
                LoginRequest request,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                return Results.Ok(await mediator.Send(request.ToLoginCommand(), cancellationToken));
            })
                .WithTags("Users")
                .AllowAnonymous();

            return app;
        }
    }
}
