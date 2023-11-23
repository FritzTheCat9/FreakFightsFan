using FreakFightsFan.Blazor;
using FreakFightsFan.Blazor.Pages.Error;
using FreakFightsFan.Blazor.Services;
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
builder.Services.AddScoped<IHttpService, HttpService>();
builder.Services.AddScoped<IFighterHttpService, FighterHttpService>();
builder.Services.AddScoped<IFederationHttpService, FederationHttpService>();
builder.Services.AddScoped<IEventHttpService, EventHttpService>();
builder.Services.AddScoped<IImageHttpService, ImageHttpService>();
builder.Services.AddScoped<IMyDictionaryHttpService, MyDictionaryHttpService>();
builder.Services.AddScoped<IMyDictionaryItemHttpService, MyDictionaryItemHttpService>();

await builder.Build().RunAsync();
