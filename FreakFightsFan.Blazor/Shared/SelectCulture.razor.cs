using FreakFightsFan.Blazor.Localization;
using FreakFightsFan.Shared.Localization;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using System.Globalization;

namespace FreakFightsFan.Blazor.Shared
{
    public partial class SelectCulture : ComponentBase
    {
        private Culture CurrentCulture { get; set; }

        [Inject] public ILocalizationProvider LocalizationProvider { get; set; }
        [Inject] public IStringLocalizer<App> Localizer { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        protected override void OnInitialized()
        {
            var culture = LocalizationConsts.SupportedCultures.FirstOrDefault(x => x.CultureInfo.Name == CultureInfo.CurrentCulture.Name);
            CurrentCulture = culture is not null ? culture : LocalizationConsts.SupportedCultures[0];
        }

        private void OnValueChanged(Culture culture)
        {
            LocalizationProvider.SetCulture(culture.CultureInfo.Name);
            NavigationManager.NavigateTo(NavigationManager.Uri, forceLoad: true);
        }
    }
}