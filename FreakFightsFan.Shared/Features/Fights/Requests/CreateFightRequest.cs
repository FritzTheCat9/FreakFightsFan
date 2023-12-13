using FreakFightsFan.Shared.Features.Fighters.Responses;
using FreakFightsFan.Shared.Features.Fights.Helpers;

namespace FreakFightsFan.Shared.Features.Fights.Requests
{
    public class CreateFightRequest
    {
        public int EventId { get; set; }
        public List<CreateTeamModel> Teams { get; set; }
    }

    public class CreateTeamModel
    {
        public List<TeamFighterModel> Fighters { get; set; }
    }

    public class TeamFighterModel
    {
        public int FighterId { get; set; }
        public FightResult FightResult { get; set; }
    }

    // Helpers models for frontend

    public class TeamHelperModel
    {
        public int Number { get; set; }
        public List<FighterHelperModel> Fighters { get; set; }
    }

    public class FighterHelperModel
    {
        public FighterDto Fighter { get; set; }
        public FightResult FightResult { get; set; }
    }
}
