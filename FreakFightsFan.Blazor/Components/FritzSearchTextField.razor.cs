using FreakFightsFan.Blazor.Localization;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using System.Linq.Expressions;

namespace FreakFightsFan.Blazor.Components;

public partial class FritzSearchTextField(
    IStringLocalizer<App> localizer)
    : ComponentBase
{
    [Parameter] public EventCallback<string> OnSearch { get; set; }
    [Parameter] public string Value { get; set; }
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public Expression<Func<string>> For { get; set; }
    [Parameter] public string Placeholder { get; set; }

    protected override void OnParametersSet()
    {
        if (string.IsNullOrWhiteSpace(Placeholder))
        {
            Placeholder = localizer[nameof(AppStrings.Search)];
        }
    }

    private async Task OnValueChanged(string newValue)
    {
        Value = newValue;
        await ValueChanged.InvokeAsync(newValue);
        await OnSearch.InvokeAsync(newValue);
    }
}