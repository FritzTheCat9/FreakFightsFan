using FreakFightsFan.Shared.Extensions;

namespace FreakFightsFan.Blazor.Clients
{
    public static class ApiClientsExtensions
    {
        private const string _sectionName = "Api";

        public static IServiceCollection AddApiClients(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.Configure<ApiOptions>(configuration.GetRequiredSection(_sectionName));
            var apiOptions = configuration.GetOptions<ApiOptions>(_sectionName);

            services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(apiOptions.Url) });

            services.AddScoped<IApiClient, ApiClient>();
            services.AddScoped<IFederationApiClient, FederationApiClient>();
            services.AddScoped<IEventApiClient, EventApiClient>();
            services.AddScoped<IFightApiClient, FightApiClient>();
            services.AddScoped<ITeamApiClient, TeamApiClient>();
            services.AddScoped<IFighterApiClient, FighterApiClient>();
            services.AddScoped<IImageApiClient, ImageApiClient>();
            services.AddScoped<IMyDictionaryApiClient, MyDictionaryApiClient>();
            services.AddScoped<IMyDictionaryItemApiClient, MyDictionaryItemApiClient>();
            services.AddScoped<IUserApiClient, UserApiClient>();

            return services;
        }
    }
}
