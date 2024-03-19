using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FreakFightsFan.Blazor.Components
{
    public partial class FritzTextField : MudTextField<string>
    {
        [Parameter] public bool HideField { get; set; }

        private void OnValueChanged(string value) 
            => SetValueAsync(value);
    }
}