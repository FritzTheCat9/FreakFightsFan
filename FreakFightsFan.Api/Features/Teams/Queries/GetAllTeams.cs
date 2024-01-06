using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Teams.Extensions;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Teams.Requests;
using FreakFightsFan.Shared.Features.Teams.Responses;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Teams.Queries
{
    public static class GetAllTeams
    {
        public class Query : IRequest<PagedList<TeamDto>>, IPagedQuery
        {
            public int Page { get; set; }
            public int PageSize { get; set; }
        }

        public class Validator : AbstractValidator<Query>
        {

        }

        public class Handler : IRequestHandler<Query, PagedList<TeamDto>>
        {
            private readonly ITeamRepository _teamRepository;

            public Handler(ITeamRepository teamRepository)
            {
                _teamRepository = teamRepository;
            }

            public async Task<PagedList<TeamDto>> Handle(Query query, CancellationToken cancellationToken)
            {
                var teamsQuery = _teamRepository.AsQueryable();

                var teamsPagedList = PageListExtensions<TeamDto>.Create(
                    teamsQuery.Select(x => x.ToDto()),
                    query.Page,
                    query.PageSize);

                return await Task.FromResult(teamsPagedList);
            }
        }

        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/teams/all", async (
                GetAllTeamsRequest request,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                return Results.Ok(await mediator.Send(request.ToGetAllTeamsQuery(), cancellationToken));
            })
                .WithTags("Teams")
                .RequireAuthorization(Policy.Admin);

            return app;
        }
    }
}
