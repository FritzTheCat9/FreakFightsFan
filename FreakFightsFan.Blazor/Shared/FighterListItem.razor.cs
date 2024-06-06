using FreakFightsFan.Shared.Features.Fights.Helpers;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using static FreakFightsFan.Shared.Features.Fights.Commands.CreateFight;

namespace FreakFightsFan.Blazor.Shared
{
    public partial class FighterListItem : ComponentBase
    {
        [Parameter] public FighterHelperModel FighterHelperModel { get; set; }
        [Parameter] public EventCallback OnDeleteFighter { get; set; }
        [Parameter] public EventCallback<FightResult> FightResultChanged { get; set; }

        [Inject] public IStringLocalizer<App> Localizer { get; set; }

        private void DeleteFighter() 
            => OnDeleteFighter.InvokeAsync();

        public async Task OnFightResultChanged(FightResult fightResult)
        {
            FighterHelperModel.FightResult = fightResult;
            await FightResultChanged.InvokeAsync(fightResult);
        }
    }
}