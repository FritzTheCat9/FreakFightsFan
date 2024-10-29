using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Blazor.Pages.Error;

public partial class UnauthorizedErrorPage(
    IStringLocalizer<App> localizer)
    : ComponentBase { }