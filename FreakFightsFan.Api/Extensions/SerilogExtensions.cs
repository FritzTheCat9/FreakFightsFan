using Serilog;

namespace FreakFightsFan.Api.Extensions
{
    public static class SerilogExtensions
    {
        private const string _sectionName = "Log";

        public static IServiceCollection AddMySerilog(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<LogOptions>(configuration.GetRequiredSection(_sectionName));
            var logOptions = configuration.GetOptions<LogOptions>(_sectionName);

            services.AddSerilog(x =>
            {
                x.WriteTo.Console();
                x.WriteTo.File(logOptions.FilePath, rollingInterval: RollingInterval.Day);
                x.WriteTo.Seq(logOptions.SeqUrl);
                x.MinimumLevel.Information();
                x.MinimumLevel.Override("Microsoft.AspNetCore", Serilog.Events.LogEventLevel.Information);
                x.MinimumLevel.Override("Microsoft.EntityFrameworkCore.Database.Command", Serilog.Events.LogEventLevel.Warning);
            });

            return services;
        }
    }

    public class LogOptions
    {
        public string FilePath { get; set; }
        public string SeqUrl { get; set; }
    }
}
