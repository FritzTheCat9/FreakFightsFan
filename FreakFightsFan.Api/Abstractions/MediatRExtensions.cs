using FluentValidation;
using FreakFightsFan.Api.Behaviors;
using System.Reflection;

namespace FreakFightsFan.Api.Abstractions
{
    public static class MediatRExtensions
    {
        public static IServiceCollection AddMediatr(this IServiceCollection services)
        {
            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
                config.AddOpenBehavior(typeof(ValidationPipelineBehavior<,>));
                config.AddOpenBehavior(typeof(UnitOfWorkPipelineBehavior<,>));
            });

            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            ValidatorOptions.Global.LanguageManager.Enabled = false;

            return services;
        }
    }
}
