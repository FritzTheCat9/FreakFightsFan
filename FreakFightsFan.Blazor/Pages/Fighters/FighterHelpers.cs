using FreakFightsFan.Shared.Features.Fights.Helpers;
using MudBlazor;

namespace FreakFightsFan.Blazor.Pages.Fighters;

public static class FighterHelpers
{
    public static string GetFightResultColor(FightResult fightResult)
    {
        return fightResult switch
        {
            FightResult.Upcoming => Colors.Gray.Default,
            FightResult.Win => Colors.Green.Default,
            FightResult.Loss => Colors.Red.Default,
            FightResult.Draw => Colors.Gray.Default,
            FightResult.NoContest => Colors.Blue.Default,
            _ => Colors.Gray.Default
        };
    }
}