using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Blazor.Pages;

public partial class IndexPage : ComponentBase
{
    [Inject] public IStringLocalizer<App> Localizer { get; set; }
}