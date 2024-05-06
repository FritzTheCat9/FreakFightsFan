using Blazored.LocalStorage;
using FreakFightsFan.Blazor.Auth;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using FreakFightsFan.Blazor.Extensions;
using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Blazor.Localization;
using FreakFightsFan.Blazor;
using FreakFightsFan.Blazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddApiClients(builder.Configuration)
                .AddFluentValidation()
                .AddExceptions()
                .AddAuth()
                .AddMyLocalization()
                .AddServices();

builder.Services.AddMudServices();
builder.Services.AddBlazoredLocalStorage();

builder.Logging.AddFilter("Microsoft.AspNetCore.Authorization.*", LogLevel.None);

var host = builder.Build();

await host.UseMyLocalization();

await host.RunAsync();
