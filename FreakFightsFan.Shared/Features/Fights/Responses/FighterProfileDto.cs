using FreakFightsFan.Shared.Features.Fights.Helpers;

namespace FreakFightsFan.Shared.Features.Fights.Responses;

public class FighterProfileDto
{
    public List<ProfileFightDto> ProfileFights { get; set; }
    public FighterFightsStats Stats { get; set; }
}

public class ProfileFightDto
{
    public FightDto Fight { get; set; }
    public FightResult FightResult { get; set; }
}

public class FighterFightsStats
{
    public int Upcoming { get; set; }
    public int Win { get; set; }
    public int Loss { get; set; }
    public int Draw { get; set; }
    public int NoContest { get; set; }
}