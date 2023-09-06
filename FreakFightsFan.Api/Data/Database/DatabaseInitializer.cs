using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FreakFightsFan.Api.Data.Database
{
    public class DatabaseInitializer : IHostedService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IClock _clock;

        public DatabaseInitializer(IServiceProvider serviceProvider, IClock clock)
        {
            _serviceProvider = serviceProvider;
            _clock = clock;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                dbContext.Database.Migrate();

                var fighters = dbContext.Fighters.ToList();

                if (fighters.Any())
                {
                    return Task.CompletedTask;
                }

                fighters = new List<Fighter>
                {
                    new Fighter { FirstName = "Marcin", LastName = "Dubiel", Nickname = "Dubiel", Created = _clock.Current(), Modified =  _clock.Current()},
                    new Fighter { FirstName = "Kacper", LastName = "Błoński", Nickname = "Crusher", Created = _clock.Current(), Modified =  _clock.Current()},
                    new Fighter { FirstName = "Sylwester", LastName = "Wardęga", Nickname = "Zwyrol", Created = _clock.Current(), Modified =  _clock.Current()},
                    new Fighter { FirstName = "Michał", LastName = "Baron", Nickname = "Boxdel" , Created = _clock.Current(), Modified =  _clock.Current()},
                };

                dbContext.Fighters.AddRange(fighters);
                dbContext.SaveChanges();
            }

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
    }
}
