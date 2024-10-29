using FreakFightsFan.Shared.Features.Fighters.Responses;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Blazor.Shared;

public partial class DisplayFighterInTeam(
    NavigationManager navigationManager,
    IStringLocalizer<App> localizer)
    : ComponentBase
{
    [Parameter] public FighterInTeamDto FighterInTeam { get; set; }

    private void RedirectToFighterProfile(int fighterId)
    {
        navigationManager.NavigateTo($"/fighter/{fighterId}");
    }
}