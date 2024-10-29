using Microsoft.AspNetCore.Components;
using System.Linq.Expressions;

namespace FreakFightsFan.Blazor.Components;

public partial class FritzSelect<T>
{
    [Parameter] public List<T> ItemsToSelect { get; set; } = [];
    [Parameter] public EventCallback<T> OnSelect { get; set; }
    [Parameter] public T Value { get; set; }
    [Parameter] public EventCallback<T> ValueChanged { get; set; }
    [Parameter] public Expression<Func<T>> For { get; set; }
    [Parameter] public string Label { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }

    private async Task OnSelectedValuesChanged(IEnumerable<T> value)
    {
        var selected = value.FirstOrDefault();

        Value = selected;
        await ValueChanged.InvokeAsync(selected);

        await OnSelect.InvokeAsync(selected);
    }
}