using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Blazor
{
    public partial class App
    {
        [Inject] public IStringLocalizer<App> Localizer { get; set; }
    }
}