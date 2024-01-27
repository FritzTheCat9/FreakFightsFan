using FreakFightsFan.Shared.Features.Fights.Helpers;
using MudBlazor;

namespace FreakFightsFan.Blazor.Pages.Fighters
{
    public static class FighterHelpers
    {
        public static string GetFightResultColor(FightResult fightResult)
            => fightResult switch
            {
                FightResult.UPCOMING => Colors.Grey.Default,
                FightResult.WIN => Colors.Green.Default,
                FightResult.LOSS => Colors.Red.Default,
                FightResult.DRAW => Colors.Grey.Default,
                FightResult.NO_CONTEST => Colors.Blue.Default,
                _ => Colors.Grey.Default,
            };
    }
}
