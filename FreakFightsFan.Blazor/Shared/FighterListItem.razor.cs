using FreakFightsFan.Shared.Features.Fights.Commands;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Blazor.Shared
{
    public partial class FighterListItem : ComponentBase
    {
        [Parameter] public CreateFight.FighterHelperModel FighterHelperModel { get; set; }
        [Parameter] public EventCallback OnDeleteFighter { get; set; }

        [Inject] public IStringLocalizer<App> Localizer { get; set; }

        private void DeleteFighter() 
            => OnDeleteFighter.InvokeAsync();
    }
}