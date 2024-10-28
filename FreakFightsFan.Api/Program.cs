using FreakFightsFan.Api.Auth;
using FreakFightsFan.Api.Data.Database;
using FreakFightsFan.Api.Emails;
using FreakFightsFan.Api.Exceptions;
using FreakFightsFan.Api.Extensions;
using FreakFightsFan.Api.Localization;
using FreakFightsFan.Api.Logging;
using FreakFightsFan.Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwagger()
    .AddMyCors(builder.Configuration)
    .AddMediatr()
    .AddDatabase(builder.Configuration)
    .AddAuth(builder.Configuration)
    .AddServices(builder.Configuration)
    .AddEmails(builder.Configuration)
    .AddExceptionMiddleware()
    .AddMyLocalization()
    .AddLogging(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "freakfightsfan.api");
        options.RoutePrefix = string.Empty;
    });
}

app.UseMyLocalization()
    .UseExceptionMiddleware()
    .AddEndpoints()
    .UseMyCors()
    .UseAuth();

app.UseFileServer();

app.Run();

public partial class Program { }