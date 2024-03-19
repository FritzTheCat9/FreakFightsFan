using FreakFightsFan.Blazor.Localization;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;

namespace FreakFightsFan.Blazor.Pages.Users
{
    public partial class SettingsPage : ComponentBase
    {
        private List<BreadcrumbItem> _items;

        [Inject] public IStringLocalizer<App> Localizer { get; set; }

        protected override void OnInitialized()
        {
            _items =
            [
                new(Localizer[nameof(AppStrings.Settings)], href: null, disabled: true),
            ];
        }
    }
}