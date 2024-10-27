using Blazored.LocalStorage;
using FreakFightsFan.Shared.Features.Users.Helpers;

namespace FreakFightsFan.Blazor.Services;

public interface IThemeColorProvider
{
    Task<ThemeColor> GetThemeColor();
    Task SetThemeColor(ThemeColor themeColor);
}

public class ThemeColorProvider(ILocalStorageService localStorageService) : IThemeColorProvider
{
    private const string _themeColor = "ThemeColor";

    public async Task<ThemeColor> GetThemeColor()
    {
        return await localStorageService.GetItemAsync<ThemeColor?>(_themeColor) ?? ThemeColor.System;
    }

    public async Task SetThemeColor(ThemeColor value)
    {
        await localStorageService.SetItemAsync(_themeColor, value);
    }
}