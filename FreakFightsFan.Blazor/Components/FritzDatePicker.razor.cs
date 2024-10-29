using Microsoft.AspNetCore.Components;
using System.Linq.Expressions;

namespace FreakFightsFan.Blazor.Components;

public partial class FritzDatePicker : ComponentBase
{
    [Parameter] public DateTime? Date { get; set; }
    [Parameter] public EventCallback<DateTime?> DateChanged { get; set; }
    [Parameter] public Expression<Func<DateTime?>> For { get; set; }
    [Parameter] public string Label { get; set; }
    [Parameter] public bool Editable { get; set; } = true;

    private async Task OnDateChanged(DateTime? newValue)
    {
        Date = newValue;
        await DateChanged.InvokeAsync(newValue);
    }
}