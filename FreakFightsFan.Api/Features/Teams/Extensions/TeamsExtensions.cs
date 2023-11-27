using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Features.Teams.Queries;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Teams.Responses;
using System.Linq.Expressions;

namespace FreakFightsFan.Api.Features.Teams.Extensions
{
    public static class TeamsExtensions
    {
        public static TeamDto ToDto(this Team team)
        {
            return new TeamDto
            {
                Id = team.Id,
                Created = team.Created,
                Modified = team.Modified,
                Name = team.Name,
            };
        }

        public static IQueryable<Team> FilterTeams(this IQueryable<Team> teams, GetAllTeams.Query query)
        {
            var searchTerm = query.SearchTerm.ToLower().Trim();
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                teams = teams.Where(x =>
                    x.Name.ToLower().Contains(searchTerm));
            }
            return teams;
        }

        public static IQueryable<Team> SortTeams(this IQueryable<Team> teams, GetAllTeams.Query query)
        {
            return query.SortOrder switch
            {
                SortOrder.Ascending => teams.OrderBy(GetTeamSortProperty(query)),
                SortOrder.Descending => teams.OrderByDescending(GetTeamSortProperty(query)),
                SortOrder.None => teams,
                _ => teams,
            };
        }

        private static Expression<Func<Team, object>> GetTeamSortProperty(GetAllTeams.Query query)
        {
            return query.SortColumn.ToLowerInvariant() switch
            {
                "name" => team => team.Name,
                _ => team => team.Name,
            };
        }
    }
}
