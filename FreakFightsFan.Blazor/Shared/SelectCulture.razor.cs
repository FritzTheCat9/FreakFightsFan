using FreakFightsFan.Blazor.Localization;
using FreakFightsFan.Shared.Localization;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using System.Globalization;

namespace FreakFightsFan.Blazor.Shared;

public partial class SelectCulture(
    ILocalizationProvider localizationProvider,
    IStringLocalizer<App> localizer,
    NavigationManager navigationManager)
    : ComponentBase
{
    private Culture CurrentCulture { get; set; }

    protected override void OnInitialized()
    {
        var culture =
            LocalizationConsts.SupportedCultures.FirstOrDefault(x
                => x.CultureInfo.Name == CultureInfo.CurrentCulture.Name);
        CurrentCulture = culture ?? LocalizationConsts.SupportedCultures[0];
    }

    private void OnValueChanged(Culture culture)
    {
        localizationProvider.SetCulture(culture.CultureInfo.Name);
        navigationManager.NavigateTo(navigationManager.Uri, true);
    }
}