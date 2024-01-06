using FreakFightsFan.Api.Features.Images.Extensions;

namespace FreakFightsFan.Api.Services
{
    public static class ServiceExtensions
    {
        private const string _sectionName = "Image";

        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IFightService, FightService>();
            services.AddScoped<IMyDictionaryService, MyDictionaryService>();
            services.AddScoped<ITeamService, TeamService>();

            services.AddScoped<IImageService, ImageService>();
            services.Configure<ImageOptions>(configuration.GetRequiredSection(_sectionName));
            services.AddHttpContextAccessor();

            return services;
        }
    }
}
