namespace FreakFightsFan.Shared.Features.Fights.Helpers
{
    public enum FightResult
    {
        UPCOMING = 0,
        WIN = 1,
        LOSS = 2,
        DRAW = 3,
        NO_CONTEST = 4,
    }

    public static class FightResultExtensions
    {
        public static string ToText(this FightResult fightResult)
        {
            switch (fightResult)
            {
                case FightResult.UPCOMING:
                    return "Upcoming";
                case FightResult.WIN:
                    return "Win";
                case FightResult.LOSS:
                    return "Loss";
                case FightResult.DRAW:
                    return "Draw";
                case FightResult.NO_CONTEST:
                    return "No Contest";
                default:
                    return "Upcoming";
            }
        }
    }
}
