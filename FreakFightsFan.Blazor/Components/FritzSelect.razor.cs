using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FreakFightsFan.Blazor.Components
{
    public partial class FritzSelect<T> : MudSelect<T>
    {
        [Parameter] public List<T> ItemsToSelect { get; set; } = [];
        [Parameter] public EventCallback<T> OnSelect { get; set; }

        private async Task OnSelectedValuesChanged(IEnumerable<T> value)
        {
            var selected = value.FirstOrDefault();
            await SetValueAsync(selected);
            await OnSelect.InvokeAsync(selected);
        }
    }
}