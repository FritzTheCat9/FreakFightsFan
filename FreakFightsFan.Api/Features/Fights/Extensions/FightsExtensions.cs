using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Features.Teams.Extensions;
using FreakFightsFan.Shared.Features.Fights.Responses;

namespace FreakFightsFan.Api.Features.Fights.Extensions
{
    public static class FightsExtensions
    {
        public static FightDto ToDto(this Fight fight)
        {
            return new FightDto
            {
                Id = fight.Id,
                Created = fight.Created,
                Modified = fight.Modified,
                EventId = fight.EventId,
                Teams = fight.Teams.Select(x => x.ToDto()).ToList()
            };
        }
    }
}
