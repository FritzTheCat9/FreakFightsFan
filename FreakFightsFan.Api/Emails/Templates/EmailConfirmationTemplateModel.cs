using FreakFightsFan.Api.Localization;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Api.Emails.Templates
{
    public class EmailConfirmationTemplateModel : BaseTemplateModel
    {
        public string UserName { get; set; }
        public string Link { get; set; }

        public EmailConfirmationTemplateModel(IStringLocalizer<EmailTranslation> localizer)
        {
            Subject = localizer[nameof(EmailTranslationString.EmailConfirmationSubject)];
            TemplateFileName = localizer[nameof(EmailTranslationString.EmailConfirmationTemplateFileName)];
        }
    }
}
