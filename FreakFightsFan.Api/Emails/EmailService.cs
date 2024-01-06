using FluentEmail.Core;
using Microsoft.Extensions.Options;

namespace FreakFightsFan.Api.Emails
{
    public interface IEmailService
    {
        Task SendEmail<T>(string to, T model) where T : BaseTemplateModel;
    }

    public class EmailService : IEmailService
    {
        private readonly EmailOptions _options;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IFluentEmail _fluentEmail;
        private readonly string _templatesFolder;

        public EmailService(IOptions<EmailOptions> options, IWebHostEnvironment webHostEnvironment, IFluentEmail fluentEmail)
        {
            _options = options.Value;
            _webHostEnvironment = webHostEnvironment;
            _fluentEmail = fluentEmail;
            _templatesFolder = $"{_webHostEnvironment.ContentRootPath}\\Emails\\Templates";
        }

        public async Task SendEmail<T>(string to, T model) where T : BaseTemplateModel
        {
            if (!_options.SendEmails)
            {
                // TODO: log that sending emails is disabled in appsettings
                return;
            }

            var email = _fluentEmail
                .SetFrom(_options.Email)
                .To(to)
                .Subject(model.Subject)
                .UsingTemplateFromFile($"{_templatesFolder}//{model.TemplateFileName}", model);

            await email.SendAsync();

            // TODO: log that sending email is successfully send
        }
    }

    public class EmailData<TemplateModel>
    {
        public string To { get; set; }
        public TemplateModel Model { get; set; }
    }

    public class BaseTemplateModel
    {
        public string Subject { get; set; }
        public string TemplateFileName { get; set; }
    }
}
