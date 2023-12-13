using FreakFightsFan.Shared.Features.Fights.Helpers;

namespace FreakFightsFan.Api.Data.Entities
{
    public class TeamFighter
    {
        public int Id { get; set; }
        public FightResult FightResult { get; set; }

        public int FighterId { get; set; }
        public Fighter Fighter { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
