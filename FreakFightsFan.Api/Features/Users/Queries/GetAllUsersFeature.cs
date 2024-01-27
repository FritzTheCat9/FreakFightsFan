using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Extensions;
using FreakFightsFan.Api.Features.Users.Extensions;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Users.Helpers;
using FreakFightsFan.Shared.Features.Users.Queries;
using FreakFightsFan.Shared.Features.Users.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Users.Queries
{
    public static class GetAllUsersFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/users/all", async (
                GetAllUsers.Query query,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
                .WithTags("Users")
                .RequireAuthorization(Policy.Admin);

            return app;
        }

        public class Handler : IRequestHandler<GetAllUsers.Query, PagedList<UserDto>>
        {
            private readonly IUserRepository _userRepository;

            public Handler(IUserRepository userRepository)
            {
                _userRepository = userRepository;
            }

            public async Task<PagedList<UserDto>> Handle(
                GetAllUsers.Query query,
                CancellationToken cancellationToken)
            {
                var usersQuery = _userRepository.AsQueryable();

                usersQuery = usersQuery.FilterMyUsers(query);
                usersQuery = usersQuery.SortMyUsers(query);

                var usersPagedList = PageListExtensions<UserDto>.Create(usersQuery.Select(x => x.ToDto()),
                                                                        query.Page,
                                                                        query.PageSize);

                return await Task.FromResult(usersPagedList);
            }
        }
    }
}
