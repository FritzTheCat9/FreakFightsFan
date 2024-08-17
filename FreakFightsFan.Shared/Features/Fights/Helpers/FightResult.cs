using System.Globalization;
using System.Resources;

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
        private static readonly string _resourceFileNamespace = "FreakFightsFan.Shared.Localization.Resources.FightResultConsts";
        private static readonly ResourceManager _resourceManager = new(_resourceFileNamespace, typeof(FightResultExtensions).Assembly);
        
        public static string ToText(this FightResult fightResult)
            => fightResult switch
            {
                FightResult.UPCOMING => _resourceManager.GetString("Upcoming", CultureInfo.CurrentCulture),
                FightResult.WIN => _resourceManager.GetString("Win", CultureInfo.CurrentCulture),
                FightResult.LOSS => _resourceManager.GetString("Loss", CultureInfo.CurrentCulture),
                FightResult.DRAW => _resourceManager.GetString("Draw", CultureInfo.CurrentCulture),
                FightResult.NO_CONTEST => _resourceManager.GetString("NoContest", CultureInfo.CurrentCulture),
                _ => _resourceManager.GetString("Upcoming", CultureInfo.CurrentCulture),
            };
    }
}
