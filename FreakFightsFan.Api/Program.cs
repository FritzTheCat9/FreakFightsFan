using FreakFightsFan.Api.Auth;
using FreakFightsFan.Api.Data;
using FreakFightsFan.Api.Emails;
using FreakFightsFan.Api.Exceptions;
using FreakFightsFan.Api.Extensions;
using FreakFightsFan.Api.Localization;
using FreakFightsFan.Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwagger();
builder.Services.AddCORS(builder.Configuration);
builder.Services.AddMediatr();
builder.Services.AddDatabase(builder.Configuration);
builder.Services.AddAuth(builder.Configuration);
builder.Services.AddServices(builder.Configuration);
builder.Services.AddEmails(builder.Configuration);
builder.Services.AddExceptionMiddleware();
builder.Services.AddMyLocalization();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseMyLocalization();
app.UseExceptionMiddleware();
app.UseCORS();
app.UseAuth();
app.UseFileServer();
app.AddEndpoints();

app.Run();

public partial class Program { }