using FreakFightsFan.Shared.Features.Fighters.Responses;

namespace FreakFightsFan.Shared.Features.Teams.Responses;

public class TeamDto
{
    public int Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }

    public int Number { get; set; }
    public int FightId { get; set; }
    public List<FighterInTeamDto> FighterInTeams { get; set; }
}