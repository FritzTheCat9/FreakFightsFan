using System.Diagnostics.CodeAnalysis;

namespace FreakFightsFan.Shared.Localization
{
    public static class ValidationConsts
    {
        public static readonly int MaximumStringLength = 50;
        public static readonly int MinimumStringLength = 7;

        [StringSyntax(StringSyntaxAttribute.Regex)]
        public static readonly string CodeRegex 
            = "^[A-Z0-9_]+$";

        [StringSyntax(StringSyntaxAttribute.Regex)]
        public static readonly string UserNameRegex 
            = "^[a-zA-Z0-9_]+$";

        [StringSyntax(StringSyntaxAttribute.Regex)]
        public static readonly string InstagramUrlRegex 
            = "^(?:https?:\\/\\/)?(?:www\\.)?instagram\\.com\\/([a-zA-Z0-9_\\.]{1,30})\\/?$";

        [StringSyntax(StringSyntaxAttribute.Regex)]
        public static readonly string YoutubeVideoUrlRegex 
            = "^(?:https?:\\/\\/)?(?:www\\.)?(?:youtube\\.com\\/(?:[^\\/\\n\\s]+\\/\\S+\\/|(?:v|e(?:mbed)?)\\/|\\S*?[?&]v=)|youtu\\.be\\/)([a-zA-Z0-9_-]{11})";
    }
}
