using FreakFightsFan.Blazor;
using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Pages.Error;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddMudServices();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7277") });
builder.Services.AddScoped<IExceptionHandler, ExceptionHandler>();
builder.Services.AddSingleton<ValidationErrors>();
builder.Services.AddScoped<IApiClient, ApiClient>();
builder.Services.AddScoped<IFederationApiClient, FederationApiClient>();
builder.Services.AddScoped<IEventApiClient, EventApiClient>();
builder.Services.AddScoped<IFightApiClient, FightApiClient>();
builder.Services.AddScoped<ITeamApiClient, TeamApiClient>();
builder.Services.AddScoped<IFighterApiClient, FighterApiClient>();
builder.Services.AddScoped<IImageApiClient, ImageApiClient>();
builder.Services.AddScoped<IMyDictionaryApiClient, MyDictionaryApiClient>();
builder.Services.AddScoped<IMyDictionaryItemApiClient, MyDictionaryItemApiClient>();
builder.Services.AddScoped<IMyDictionaryItemClientHelper, MyDictionaryItemClientHelper>();

await builder.Build().RunAsync();
