using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Features.Fighters.Extensions;
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
                Number = team.Number,
                FightId = team.FightId,
                Fighters = team.Fighters.Select(x => x.ToDto()).ToList(),
            };
        }
    }
}
