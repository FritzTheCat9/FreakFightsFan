using System.Globalization;

namespace FreakFightsFan.Blazor.Localization
{
    public static class LocalizationConsts
    {
        public static readonly string ResourcesFolder = "Resources";
        public static readonly string CultureKey = "Culture";
        public static readonly string DefaultCulture = "en-US";

        public static readonly Culture[] SupportedCultures = [
            new() { Country = "English US", CultureInfo = new CultureInfo("en-US") },
            new() { Country = "English GB", CultureInfo = new CultureInfo("en-GB") },
            new() { Country = "Polish", CultureInfo = new CultureInfo("pl") },
        ];
    }

    public class Culture
    {
        public string Country { get; set; }
        public CultureInfo CultureInfo { get; set; }
    }
}
