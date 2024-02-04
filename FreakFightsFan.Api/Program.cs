using FreakFightsFan.Api.Auth;
using FreakFightsFan.Api.Data;
using FreakFightsFan.Api.Emails;
using FreakFightsFan.Api.Exceptions;
using FreakFightsFan.Api.Extensions;
using FreakFightsFan.Api.Localization;
using FreakFightsFan.Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwagger()
                .AddCORS(builder.Configuration)
                .AddMediatr()
                .AddDatabase(builder.Configuration)
                .AddAuth(builder.Configuration)
                .AddServices(builder.Configuration)
                .AddEmails(builder.Configuration)
                .AddExceptionMiddleware()
                .AddMyLocalization()
                .AddMySerilog(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseMyLocalization()
   .UseExceptionMiddleware()
   .UseCORS()
   .UseAuth()
   .AddEndpoints();

app.UseFileServer();

app.Run();

public partial class Program { }