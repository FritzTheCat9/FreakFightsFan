using System.Globalization;

namespace FreakFightsFan.Shared.Localization;

public static class LocalizationConsts
{
    public const string ResourcesFolder = "Localization/Resources";
    public const string CultureKey = "Culture";
    public const string DefaultCulture = "en";

    public static readonly Culture[] SupportedCultures =
    [
        new() { Country = "English", CultureInfo = new CultureInfo("en") },
        new() { Country = "Polski", CultureInfo = new CultureInfo("pl") }
    ];
}

public class Culture
{
    public string Country { get; set; }
    public CultureInfo CultureInfo { get; set; }
}