using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Teams.Extensions;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Teams.Queries;
using FreakFightsFan.Shared.Features.Teams.Responses;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Teams.Queries
{
    public static class GetTeamFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapGet("/api/teams/{id}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var query = new GetTeam.Query() { Id = id };
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
                .WithName("GetTeam")
                .WithTags("Teams")
                .RequireAuthorization(Policy.Admin);

            return app;
        }

        public class Handler : IRequestHandler<GetTeam.Query, TeamDto>
        {
            private readonly ITeamRepository _teamRepository;

            public Handler(ITeamRepository teamRepository)
            {
                _teamRepository = teamRepository;
            }

            public async Task<TeamDto> Handle(
                GetTeam.Query query,
                CancellationToken cancellationToken)
            {
                var team = await _teamRepository.Get(query.Id) ?? throw new MyNotFoundException();
                return team.ToDto();
            }
        }
    }
}
