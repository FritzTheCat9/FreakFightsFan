using Blazored.LocalStorage;
using FreakFightsFan.Blazor;
using FreakFightsFan.Blazor.Auth;
using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Blazor.Extensions;
using FreakFightsFan.Blazor.Localization;
using FreakFightsFan.Blazor.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

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
