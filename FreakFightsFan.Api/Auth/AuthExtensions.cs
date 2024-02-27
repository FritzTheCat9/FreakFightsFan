using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Shared.Extensions;
using FreakFightsFan.Shared.Features.Users.Helpers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

namespace FreakFightsFan.Api.Auth
{
    public static class AuthExtensions
    {
        private const string _sectionName = "Auth";

        public static IServiceCollection AddAuth(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.Configure<AuthOptions>(configuration.GetRequiredSection(_sectionName));
            var authOptions = configuration.GetOptions<AuthOptions>(_sectionName);

            services
                .AddAuthentication(x =>
                {
                    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(x =>
                {
                    x.Audience = authOptions.Audience;
                    x.IncludeErrorDetails = true;
                    x.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidIssuer = authOptions.Issuer,
                        ClockSkew = TimeSpan.Zero,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(authOptions.SigningKey)),
                    };

                });

            AddAuthorization(services);

            services.AddSingleton<IPasswordHasher<User>, PasswordHasher<User>>();
            services.AddSingleton<IPasswordService, PasswordService>();

            services.AddSingleton<IAuthenticator, Authenticator>();

            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IEmailConfirmationService, EmailConfirmationService>();

            return services;
        }

        public static WebApplication UseAuth(this WebApplication app)
        {
            app.UseAuthentication();
            app.UseAuthorization();

            return app;
        }

        private static void AddAuthorization(IServiceCollection services)
        {
            services.AddSingleton<IAuthorizationMiddlewareResultHandler, CustomAuthorizationMiddlewareResultHandler>();

            services.AddAuthorizationBuilder()
                .AddPolicy(Policy.User, x =>
                {
                    x.RequireClaim(ClaimTypes.Role, Policy.User);
                })
                .AddPolicy(Policy.Admin, x =>
                {
                    x.RequireClaim(ClaimTypes.Role, Policy.Admin);
                })
                .AddPolicy(Policy.SuperAdmin, x =>
                {
                    x.RequireClaim(ClaimTypes.Role, Policy.SuperAdmin);
                });
        }
    }
}
