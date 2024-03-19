using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Blazor.Shared
{
    public partial class MainLayout : LayoutComponentBase
    {
        private bool _drawerOpen = true;

        [Inject] public IStringLocalizer<App> Localizer { get; set; }

        private void DrawerToggle() 
            => _drawerOpen = !_drawerOpen;
    }
}