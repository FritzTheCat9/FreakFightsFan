using FreakFightsFan.Api.Localization;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Api.Emails.Models
{
    public class EmailConfirmationSuccessfulTemplateModel : BaseTemplateModel
    {
        public string UserName { get; set; }

        public EmailConfirmationSuccessfulTemplateModel(IStringLocalizer<EmailTranslation> localizer)
        {
            Subject = localizer[nameof(EmailTranslationString.EmailConfirmationSuccessfulSubject)];
            TemplateFileName = localizer[nameof(EmailTranslationString.EmailConfirmationSuccessfulTemplateFileName)];
        }
    }
}
