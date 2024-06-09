using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FreakFightsFan.Blazor.Components
{
    public partial class FritzBreadcrumbs : ComponentBase
    {
        [Parameter] public List<BreadcrumbItem> Items { get; set; }
    }
}