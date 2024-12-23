using FreakFightsFan.Blazor.Exceptions;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Blazor.Pages.Error;

public partial class ValidationErrorPage(
    IStringLocalizer<App> localizer,
    ValidationErrors validationErrors)
    : ComponentBase { }