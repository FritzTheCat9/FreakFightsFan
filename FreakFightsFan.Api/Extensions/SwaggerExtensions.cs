using Microsoft.OpenApi.Models;

namespace FreakFightsFan.Api.Extensions
{
    public static class SwaggerExtensions
    {
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(setup =>
            {
                setup.AddSecurityDefinition("Bearer", new()
                {
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using the Bearer scheme. Example: 'Bearer {token}'",
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "JWT",
                    Scheme = "Bearer",
                });

                setup.AddSecurityRequirement(new()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        []
                    }
                });

                // Fix for swagger bug for endpoints with name containing '+': (https://github.com/swagger-api/swagger-ui/issues/7911)
                // InvalidOperationException: Can't use schemaId "$Command" for type "$FreakFightsFan.Shared.Features.Events.Commands.UpdateEvent+Command".
                // The same schemaId is already used for type "$FreakFightsFan.Shared.Features.Events.Commands.CreateEvent+Command"
                setup.CustomSchemaIds(s => s.FullName.Replace("+", "."));
            });

            return services;
        }
    }
}
