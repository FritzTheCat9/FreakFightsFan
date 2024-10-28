using Microsoft.AspNetCore.Components;
using System.Linq.Expressions;

namespace FreakFightsFan.Blazor.Components;

public partial class FritzTextField : ComponentBase
{
    [Parameter] public string Value { get; set; }
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public Expression<Func<string>> For { get; set; }

    [Parameter] public string Label { get; set; }
    [Parameter] public bool OnlyValidateIfDirty { get; set; } = true;
    [Parameter] public bool HideField { get; set; }

    public string HiddenStyle => HideField ? "display: none;" : string.Empty;

    private async Task OnValueChanged(string newValue)
    {
        Value = newValue;
        await ValueChanged.InvokeAsync(newValue);
    }
}