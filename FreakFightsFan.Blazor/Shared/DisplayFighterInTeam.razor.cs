using FreakFightsFan.Shared.Features.Fighters.Responses;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Blazor.Shared
{
    public partial class DisplayFighterInTeam : ComponentBase
    {
        [Parameter] public FighterInTeamDto FighterInTeam { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }
        [Inject] public IStringLocalizer<App> Localizer { get; set; }

        private void RedirectToFighterProfile(int fighterId)
            => NavigationManager.NavigateTo($"/fighter/{fighterId}");
    }
}