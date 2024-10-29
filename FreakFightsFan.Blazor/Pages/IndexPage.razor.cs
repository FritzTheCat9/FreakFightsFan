using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Blazor.Pages;

public partial class IndexPage(
    IStringLocalizer<App> localizer)
    : ComponentBase { }