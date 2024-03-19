using FreakFightsFan.Shared.Features.Fighters.Responses;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Blazor.Shared
{
    public partial class DisplayFighter : ComponentBase
    {
        [Parameter] public FighterDto Fighter { get; set; }

        [Inject] public IStringLocalizer<App> Localizer { get; set; }
    }
}