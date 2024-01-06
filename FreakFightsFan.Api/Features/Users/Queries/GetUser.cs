using FluentValidation;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Fighters.Extensions;
using FreakFightsFan.Api.Features.Users.Extensions;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Users.Helpers;
using FreakFightsFan.Shared.Features.Users.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Users.Queries
{
    public static class GetUser
    {
        public class Query : IRequest<UserDto>
        {
            public int Id { get; set; }
        }

        public class Validator : AbstractValidator<Query>
        {

        }

        public class Handler : IRequestHandler<Query, UserDto>
        {
            private readonly IUserRepository _userRepository;

            public Handler(IUserRepository userRepository)
            {
                _userRepository = userRepository;
            }

            public async Task<UserDto> Handle(Query query, CancellationToken cancellationToken)
            {
                var user = await _userRepository.Get(query.Id) ?? throw new MyNotFoundException();
                return user.ToDto();
            }
        }

        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapGet("/api/users/{id}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var query = new Query() { Id = id };
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
                .WithName("GetUser")
                .WithTags("Users")
                .RequireAuthorization(Policy.Admin);

            return app;
        }
    }
}
