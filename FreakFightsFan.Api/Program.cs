using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Behaviors;
using FreakFightsFan.Api.Data.Database;
using FreakFightsFan.Api.Exceptions;
using FreakFightsFan.Api.Features.Dictionaries.Extensions;
using FreakFightsFan.Api.Features.DictionaryItems.Extensions;
using FreakFightsFan.Api.Features.Events.Extensions;
using FreakFightsFan.Api.Features.Federations.Extensions;
using FreakFightsFan.Api.Features.Fighters.Extensions;
using FreakFightsFan.Api.Features.Fights.Extensions;
using FreakFightsFan.Api.Features.Images.Extensions;
using FreakFightsFan.Api.Features.Teams.Extensions;
using FreakFightsFan.Api.Services;
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
    config.AddOpenBehavior(typeof(UnitOfWorkPipelineBehavior<,>));
});
builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
ValidatorOptions.Global.LanguageManager.Enabled = false;

builder.Services.AddMssql(builder.Configuration);
builder.Services.AddSingleton<ExceptionMiddleware>();
builder.Services.AddSingleton<IClock, Clock>();

builder.Services.AddScoped<IImageService, ImageService>();
builder.Services.AddScoped<IMyDictionaryService, MyDictionaryService>();
builder.Services.AddScoped<ITeamService, TeamService>();
builder.Services.AddHttpContextAccessor();

builder.Services.Configure<ImageOptions>(builder.Configuration.GetSection("Image"));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseMiddleware<ExceptionMiddleware>();
app.UseCors("MyCorsPolicy");
app.UseFileServer();

app.AddMyDictionaryEndpoints();
app.AddMyDictionaryItemEndpoints();
app.AddEventEndpoints();
app.AddFederationEndpoints();
app.AddFighterEndpoints();
app.AddFightEndpoints();
app.AddImageEndpoints();
app.AddTeamEndpoints();

app.Run();
