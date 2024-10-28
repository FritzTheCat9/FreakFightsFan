using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Features.TeamFighters.Extensions;
using FreakFightsFan.Api.Features.Teams.Queries;
using FreakFightsFan.Shared.Features.Teams.Responses;

namespace FreakFightsFan.Api.Features.Teams.Extensions;

public static class TeamsExtensions
{
    public static IEndpointRouteBuilder AddTeamEndpoints(this IEndpointRouteBuilder app)
    {
        GetAllTeamsFeature.Endpoint(app);
        GetTeamFeature.Endpoint(app);

        return app;
    }

    public static TeamDto ToDto(this Team team)
    {
        return new TeamDto
        {
            Id = team.Id,
            Created = team.Created,
            Modified = team.Modified,
            Number = team.Number,
            FightId = team.FightId,
            FighterInTeams = team.TeamFighters.Select(x => x.ToFighterInTeamDto()).ToList()
        };
    }
}