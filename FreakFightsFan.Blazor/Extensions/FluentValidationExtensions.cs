using FluentValidation;
using FreakFightsFan.Shared.Features.Dictionaries.Commands;
using System.Reflection;

namespace FreakFightsFan.Blazor.Extensions
{
    public static class FluentValidationExtensions
    {
        public static IServiceCollection AddFluentValidation(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(typeof(CreateMyDictionary.Validator).Assembly);
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            ValidatorOptions.Global.LanguageManager.Enabled = false;

            return services;
        }
    }
}
