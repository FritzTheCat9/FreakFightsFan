using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Blazor.Pages.Error;

public partial class ForbiddenErrorPage(
    IStringLocalizer<App> localizer)
    : ComponentBase { }