using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FreakFightsFan.Api.Data.Database
{
    public static class DataExtensions
    {
        private const string _sectionName = "Database";

        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MssqlOptions>(configuration.GetRequiredSection(_sectionName));
            var options = configuration.GetOptions<MssqlOptions>(_sectionName);

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
