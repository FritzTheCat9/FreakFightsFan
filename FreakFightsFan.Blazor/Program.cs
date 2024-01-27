using Blazored.LocalStorage;
using FreakFightsFan.Blazor.Auth;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using FreakFightsFan.Blazor.Extensions;
using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Blazor.Localization;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddApiClients()
                .AddFluentValidation()
                .AddExceptions()
                .AddAuth()
                .AddMyLocalization();

builder.Services.AddMudServices();
builder.Services.AddBlazoredLocalStorage();

var host = builder.Build();

await host.UseMyLocalization();

await host.RunAsync();
