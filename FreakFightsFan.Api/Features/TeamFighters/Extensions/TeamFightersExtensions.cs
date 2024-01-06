using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Features.Fighters.Extensions;
using FreakFightsFan.Api.Features.Images.Extensions;
using FreakFightsFan.Api.Features.Teams.Extensions;
using FreakFightsFan.Shared.Features.Fighters.Responses;

namespace FreakFightsFan.Api.Features.TeamFighters.Extensions
{
    public static class TeamFightersExtensions
    {
        public static FighterInTeamDto ToFighterInTeamDto(this TeamFighter teamFighter)
        {
            return new()
            {
                Fighter = teamFighter.Fighter.ToDto(),
                FightResult = teamFighter.FightResult,
            };
        }
    }
}
