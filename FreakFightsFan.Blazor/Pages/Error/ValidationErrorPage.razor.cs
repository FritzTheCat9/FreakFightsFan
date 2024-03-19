using FreakFightsFan.Blazor.Exceptions;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Blazor.Pages.Error
{
    public partial class ValidationErrorPage : ComponentBase
    {
        [Inject] public IStringLocalizer<App> Localizer { get; set; }
        [Inject] public ValidationErrors ValidationErrors { get; set; }
    }
}