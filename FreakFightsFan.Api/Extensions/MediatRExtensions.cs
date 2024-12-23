﻿using FluentValidation;
using FreakFightsFan.Api.Behaviors;
using FreakFightsFan.Shared.Features.Dictionaries.Commands;
using System.Reflection;

namespace FreakFightsFan.Api.Extensions;

public static class MediatRExtensions
{
    public static IServiceCollection AddMediatr(this IServiceCollection services)
    {
        services.AddMediatR(config =>
        {
            config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            config.AddOpenBehavior(typeof(LoggingBehavior<,>));
            config.AddOpenBehavior(typeof(ValidationPipelineBehavior<,>));
            config.AddOpenBehavior(typeof(UnitOfWorkPipelineBehavior<,>));
        });

        services.AddValidatorsFromAssembly(typeof(CreateMyDictionary.Validator).Assembly);
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        ValidatorOptions.Global.LanguageManager.Enabled = false;

        return services;
    }
}