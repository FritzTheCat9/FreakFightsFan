using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Blazor.Layout;

public partial class NavMenu : ComponentBase
{
    [Inject] public IStringLocalizer<App> Localizer { get; set; }
}