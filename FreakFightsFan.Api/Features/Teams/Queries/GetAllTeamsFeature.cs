using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Extensions;
using FreakFightsFan.Api.Features.Teams.Extensions;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Teams.Queries;
using FreakFightsFan.Shared.Features.Teams.Responses;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Teams.Queries
{
    public static class GetAllTeamsFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/teams/all", async (
                GetAllTeams.Query query,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
                .WithTags(Tags.Teams)
                .RequireAuthorization(Policy.Admin);

            return app;
        }

        public class Handler : IRequestHandler<GetAllTeams.Query, PagedList<TeamDto>>
        {
            private readonly ITeamRepository _teamRepository;

            public Handler(ITeamRepository teamRepository)
            {
                _teamRepository = teamRepository;
            }

            public async Task<PagedList<TeamDto>> Handle(
                GetAllTeams.Query query,
                CancellationToken cancellationToken)
            {
                var teamsQuery = _teamRepository.AsQueryable();

                var teamsPagedList = PageListExtensions<TeamDto>.Create(teamsQuery.Select(x => x.ToDto()),
                                                                        query.Page,
                                                                        query.PageSize);

                return await Task.FromResult(teamsPagedList);
            }
        }
    }
}
