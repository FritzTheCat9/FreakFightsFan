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
            => fightResult switch
            {
                FightResult.UPCOMING => "Upcoming",
                FightResult.WIN => "Win",
                FightResult.LOSS => "Loss",
                FightResult.DRAW => "Draw",
                FightResult.NO_CONTEST => "No Contest",
                _ => "Upcoming",
            };
    }
}
