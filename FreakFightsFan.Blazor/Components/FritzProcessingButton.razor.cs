using FreakFightsFan.Blazor.Localization;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;

namespace FreakFightsFan.Blazor.Components;

public partial class FritzProcessingButton
{
    private bool _processing;

    [Parameter] public string ProcessingButtonText { get; set; }
    [Parameter] public string ButtonText { get; set; }
    [Parameter] public ButtonType ButtonType { get; set; }
    [Parameter] public Color Color { get; set; }
    [Parameter] public Variant Variant { get; set; }

    [Inject] public IStringLocalizer<App> Localizer { get; set; }

    protected override void OnParametersSet()
    {
        if (string.IsNullOrWhiteSpace(ProcessingButtonText))
        {
            ProcessingButtonText = Localizer[nameof(AppStrings.Processing)];
        }
    }

    public void SetProcessing(bool processing)
    {
        _processing = processing;
        StateHasChanged();
    }

    public bool IsProcessing()
    {
        return _processing;
    }
}