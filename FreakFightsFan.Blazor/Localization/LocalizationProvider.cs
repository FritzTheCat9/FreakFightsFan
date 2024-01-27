using Blazored.LocalStorage;
using FreakFightsFan.Shared.Localization;

namespace FreakFightsFan.Blazor.Localization
{
    public interface ILocalizationProvider
    {
        Task<string> GetCulture();
        Task SetCulture(string culture);
    }

    public class LocalizationProvider : ILocalizationProvider
    {
        private readonly ILocalStorageService _localStorage;

        public LocalizationProvider(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public async Task<string> GetCulture()
        {
            var culture = await _localStorage.GetItemAsync<string>(LocalizationConsts.CultureKey);
            return culture;
        }

        public async Task SetCulture(string culture)
        {
            await _localStorage.SetItemAsync(LocalizationConsts.CultureKey, culture);
        }
    }
}
