﻿namespace FreakFightsFan.Api.Emails.Templates
{
    public class EmailConfirmationTemplateModel : BaseTemplateModel
    {
        public string UserName { get; set; }
        public string Link { get; set; }

        public EmailConfirmationTemplateModel()
        {
            Subject = "Email confirmation";
            TemplateFileName = "EmailConfirmationTemplate.cshtml";
        }
    }
}
