using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FreakFightsFan.Api.Data.Database
{
    public static class DataExtensions
    {
        private const string SectionName = "mssql";

        public static IServiceCollection AddMssql(this IServiceCollection services, IConfiguration configuration)
        {
            var section = configuration.GetSection(SectionName);
            services.Configure<MssqlOptions>(section);
            var options = configuration.GetOptions<MssqlOptions>(SectionName);

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
            services.AddHostedService<DatabaseInitializer>();

            return services;
        }

        public static T GetOptions<T>(this IConfiguration configuration, string sectionName) where T : class, new()
        {
            var options = new T();
            var section = configuration.GetSection(sectionName);
            section.Bind(options);

            return options;
        }
    }
}
