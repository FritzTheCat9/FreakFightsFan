using FreakFightsFan.Shared.Features.Fighters.Responses;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Blazor.Shared;

public partial class DisplayFighterListItem(
    IStringLocalizer<App> localizer)
    : ComponentBase
{
    [Parameter] public FighterDto Fighter { get; set; }
}