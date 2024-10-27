using FreakFightsFan.Api.Auth;
using FreakFightsFan.Shared.Extensions;

namespace FreakFightsFan.Api.Extensions;

public static class CorsExtensions
{
    private const string _policyName = "MyCorsPolicy";
    private const string _sectionName = "Auth";

    public static IServiceCollection AddMyCors(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.Configure<AuthOptions>(configuration.GetRequiredSection(_sectionName));
        var authOptions = configuration.GetOptions<AuthOptions>(_sectionName);

        services.AddCors(options =>
        {
            options.AddPolicy(_policyName, policy =>
            {
                policy.WithOrigins(authOptions.FrontendUrl)
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
        });

        return services;
    }

    public static WebApplication UseMyCors(this WebApplication app)
    {
        app.UseCors(_policyName);

        return app;
    }
}