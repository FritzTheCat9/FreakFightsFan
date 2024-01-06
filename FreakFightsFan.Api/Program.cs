using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Auth;
using FreakFightsFan.Api.Data.Database;
using FreakFightsFan.Api.Emails;
using FreakFightsFan.Api.Exceptions;
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

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseExceptionMiddleware();
app.UseCORS();
app.UseAuth();
app.UseFileServer();
app.AddEndpoints();

app.Run();

