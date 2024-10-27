using FreakFightsFan.Api.Localization;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Api.Emails.Models;

public class EmailConfirmationTemplateModel : BaseTemplateModel
{
    public string UserName { get; init; }
    public string Link { get; init; }

    public EmailConfirmationTemplateModel(IStringLocalizer<EmailTranslation> localizer)
    {
        Subject = localizer[nameof(EmailTranslationString.EmailConfirmationSubject)];
        TemplateFileName = localizer[nameof(EmailTranslationString.EmailConfirmationTemplateFileName)];
    }
}