using System.Globalization;
using System.Resources;

namespace FreakFightsFan.Shared.Features.Fights.Helpers;

public enum FightResult
{
    Upcoming = 0,
    Win = 1,
    Loss = 2,
    Draw = 3,
    NoContest = 4,
}

public static class FightResultExtensions
{
    private const string _resourceFileNamespace = "FreakFightsFan.Shared.Localization.Resources.FightResultConsts";
    private static readonly ResourceManager _resourceManager = new(_resourceFileNamespace, typeof(FightResultExtensions).Assembly);
        
    public static string ToText(this FightResult fightResult)
    {
        return fightResult switch
        {
            FightResult.Upcoming => _resourceManager.GetString("Upcoming", CultureInfo.CurrentCulture),
            FightResult.Win => _resourceManager.GetString("Win", CultureInfo.CurrentCulture),
            FightResult.Loss => _resourceManager.GetString("Loss", CultureInfo.CurrentCulture),
            FightResult.Draw => _resourceManager.GetString("Draw", CultureInfo.CurrentCulture),
            FightResult.NoContest => _resourceManager.GetString("NoContest", CultureInfo.CurrentCulture),
            _ => _resourceManager.GetString("Upcoming", CultureInfo.CurrentCulture),
        };
    }
}