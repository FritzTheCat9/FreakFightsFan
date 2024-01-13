using Blazored.LocalStorage;
using FreakFightsFan.Blazor;
using FreakFightsFan.Blazor.Auth;
using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Pages.Error;
using FreakFightsFan.Shared.Features.Dictionaries.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using System.Security.Claims;
using FluentValidation;
using System.Reflection;
using Microsoft.FluentUI.AspNetCore.Components;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddMudServices();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7277") });
builder.Services.AddFluentUIComponents();

builder.Services.AddValidatorsFromAssembly(typeof(CreateMyDictionary.Validator).Assembly);
builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
ValidatorOptions.Global.LanguageManager.Enabled = false;

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddAuthorizationCore(config =>
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
builder.Services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();
builder.Services.AddScoped<IJwtProvider, JwtProvider>();

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
builder.Services.AddScoped<IUserApiClient, UserApiClient>();

await builder.Build().RunAsync();
