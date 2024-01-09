using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Database;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Extensions;
using Microsoft.EntityFrameworkCore;

namespace FreakFightsFan.Api.Data
{
    public static class DatabaseExtensions
    {
        private const string _sectionName = "Database";

        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<DatabaseOptions>(configuration.GetRequiredSection(_sectionName));
            var options = configuration.GetOptions<DatabaseOptions>(_sectionName);

            services.AddSingleton<IClock, Clock>();

            services.AddDbContext<AppDbContext>(x =>
            {
                x.UseSqlServer(options.ConnectionString);
                x.EnableSensitiveDataLogging();
            });

            services.AddScoped<IFederationRepository, FederationRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IFightRepository, FightRepository>();
            services.AddScoped<ITeamRepository, TeamRepository>();
            services.AddScoped<IFighterRepository, FighterRepository>();
            services.AddScoped<IImageRepository, ImageRepository>();
            services.AddScoped<IMyDictionaryRepository, MyDictionaryRepository>();
            services.AddScoped<IMyDictionaryItemRepository, MyDictionaryItemRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddHostedService<DatabaseInitializer>();

            return services;
        }
    }
}
