using FreakFightsFan.Blazor.Localization;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;

namespace FreakFightsFan.Blazor.Pages.Users;

public partial class SettingsPage(
    IStringLocalizer<App> localizer)
    : ComponentBase
{
    private List<BreadcrumbItem> _items;

    protected override void OnInitialized()
    {
        _items =
        [
            new BreadcrumbItem(localizer[nameof(AppStrings.Settings)], null, true)
        ];
    }
}