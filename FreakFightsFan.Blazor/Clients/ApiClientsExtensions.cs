namespace FreakFightsFan.Blazor.Clients
{
    public static class ApiClientsExtensions
    {
        public static IServiceCollection AddApiClients(this IServiceCollection services)
        {
            services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:5001") });

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
