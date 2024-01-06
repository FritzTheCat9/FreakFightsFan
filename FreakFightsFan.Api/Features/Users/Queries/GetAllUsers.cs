using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Users.Extensions;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Users.Helpers;
using FreakFightsFan.Shared.Features.Users.Requests;
using FreakFightsFan.Shared.Features.Users.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Users.Queries
{
    public static class GetAllUsers
    {
        public class Query : IRequest<PagedList<UserDto>>, IPagedQuery, ISortedQuery
        {
            public int Page { get; set; }
            public int PageSize { get; set; }
            public string SortColumn { get; set; }
            public SortOrder SortOrder { get; set; }
            public string SearchTerm { get; set; }
        }

        public class Validator : AbstractValidator<Query>
        {

        }

        public class Handler : IRequestHandler<Query, PagedList<UserDto>>
        {
            private readonly IUserRepository _userRepository;

            public Handler(IUserRepository userRepository)
            {
                _userRepository = userRepository;
            }

            public async Task<PagedList<UserDto>> Handle(Query query, CancellationToken cancellationToken)
            {
                var usersQuery = _userRepository.AsQueryable();

                usersQuery = usersQuery.FilterMyUsers(query);
                usersQuery = usersQuery.SortMyUsers(query);

                var usersPagedList = PageListExtensions<UserDto>.Create(
                    usersQuery.Select(x => x.ToDto()),
                    query.Page,
                    query.PageSize);

                return await Task.FromResult(usersPagedList);
            }
        }

        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/users/all", async (
                GetAllUsersRequest request,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                return Results.Ok(await mediator.Send(request.ToGetAllUsersQuery(), cancellationToken));
            })
                .WithTags("Users")
                .RequireAuthorization(Policy.Admin);

            return app;
        }
    }
}
