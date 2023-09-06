using Carter;
using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Database;
using FreakFightsFan.Api.Exceptions;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("MyCorsPolicy", policy =>
    {
        policy.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
    config.AddOpenBehavior(typeof(ValidationPipelineBehavior<,>));
});
builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
ValidatorOptions.Global.LanguageManager.Enabled = false;
builder.Services.AddCarter(); 

builder.Services.AddMssql(builder.Configuration);
builder.Services.AddSingleton<ExceptionMiddleware>();
builder.Services.AddSingleton<IClock, Clock>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseMiddleware<ExceptionMiddleware>();
app.UseCors("MyCorsPolicy");
app.MapCarter();

app.Run();
