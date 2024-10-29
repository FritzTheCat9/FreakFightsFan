using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Blazor.Layout;

public partial class NavMenu(
    IStringLocalizer<App> localizer)
    : ComponentBase { }