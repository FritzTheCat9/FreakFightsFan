using FreakFightsFan.Shared.Features.Teams.Responses;

namespace FreakFightsFan.Shared.Features.Fights.Responses
{
    public class FightDto
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int OrderNumber { get; set; }
        public string VideoUrl { get; set; }

        public int EventId { get; set; }
        public List<TeamDto> Teams { get; set; }
    }
}

