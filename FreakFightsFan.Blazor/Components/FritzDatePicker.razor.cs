using MudBlazor;

namespace FreakFightsFan.Blazor.Components
{
    public partial class FritzDatePicker : MudDatePicker
    {
        private void OnDateChanged(DateTime? value) 
            => SetDateAsync(value, updateValue: true);
    }
}