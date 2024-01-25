using FreakFightsFan.Shared.Features.Users.Helpers;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace FreakFightsFan.Blazor.Auth
{
    public static class AuthExtensions
    {
        public static IServiceCollection AddAuth(this IServiceCollection services)
        {
            services.AddCascadingAuthenticationState();

            services.AddAuthorizationCore(config =>
            {
                config.AddPolicy(Policy.User, x =>
                {
                    x.RequireClaim(ClaimTypes.Role, Policy.User);
                });
                config.AddPolicy(Policy.Admin, x =>
                {
                    x.RequireClaim(ClaimTypes.Role, Policy.Admin);
                });
                config.AddPolicy("superAdmin", x =>
                {
                    x.RequireClaim(ClaimTypes.Role, "superAdmin");
                });
            });
            services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();
            services.AddScoped<IJwtProvider, JwtProvider>();

            return services;
        }
    }
}
