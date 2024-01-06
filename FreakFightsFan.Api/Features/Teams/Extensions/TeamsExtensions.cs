using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Features.Teams.Queries;
using FreakFightsFan.Shared.Features.Teams.Requests;
using FreakFightsFan.Shared.Features.Teams.Responses;
using FreakFightsFan.Api.Features.TeamFighters.Extensions;

namespace FreakFightsFan.Api.Features.Teams.Extensions
{
    public static class TeamsExtensions
    {
        public static IEndpointRouteBuilder AddTeamEndpoints(this IEndpointRouteBuilder app)
        {
            GetAllTeams.Endpoint(app);
            GetTeam.Endpoint(app);

            return app;
        }

        public static TeamDto ToDto(this Team team)
        {
            return new()
            {
                Id = team.Id,
                Created = team.Created,
                Modified = team.Modified, 
                Number = team.Number,
                FightId = team.FightId,
                FighterInTeams = team.TeamFighters.Select(x => x.ToFighterInTeamDto()).ToList(),
            };
        }

        public static GetAllTeams.Query ToGetAllTeamsQuery(this GetAllTeamsRequest request)
        {
            return new()
            {
                Page = request.Page,
                PageSize = request.PageSize,
            };
        }
    }
}
