using FreakFightsFan.Api.Localization;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Api.Emails.Models;

public class EmailConfirmationTemplateModel : BaseTemplateModel
{
    public EmailConfirmationTemplateModel(IStringLocalizer<EmailTranslation> localizer)
    {
        Subject = localizer[nameof(EmailTranslationString.EmailConfirmationSubject)];
        TemplateFileName = localizer[nameof(EmailTranslationString.EmailConfirmationTemplateFileName)];
    }

    public string UserName { get; init; }
    public string Link { get; init; }
}