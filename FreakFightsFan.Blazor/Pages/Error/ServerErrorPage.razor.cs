using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Blazor.Pages.Error
{
    public partial class ServerErrorPage : ComponentBase
    {
        [Inject] public IStringLocalizer<App> Localizer { get; set; }
    }
}