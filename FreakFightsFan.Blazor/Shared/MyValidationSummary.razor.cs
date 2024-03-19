using FreakFightsFan.Blazor.Exceptions;
using Microsoft.AspNetCore.Components;

namespace FreakFightsFan.Blazor.Shared
{
    public partial class MyValidationSummary : ComponentBase
    {
        [Parameter] public ValidationErrors validationErrors { get; set; } = new();
    }
}