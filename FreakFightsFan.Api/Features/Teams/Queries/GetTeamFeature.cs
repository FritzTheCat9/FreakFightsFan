using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Teams.Extensions;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Teams.Queries;
using FreakFightsFan.Shared.Features.Teams.Responses;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Teams.Queries;

public static class GetTeamFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapGet("/api/teams/{id:int}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var query = new GetTeam.Query { Id = id };
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
            .WithName("GetTeam")
            .WithTags(Tags.Teams)
            .RequireAuthorization(Policy.Admin);
    }

    public class Handler(ITeamRepository teamRepository) : IRequestHandler<GetTeam.Query, TeamDto>
    {
        public async Task<TeamDto> Handle(
            GetTeam.Query query,
            CancellationToken cancellationToken)
        {
            var team = await teamRepository.Get(query.Id) ?? throw new MyNotFoundException();
            return team.ToDto();
        }
    }
}