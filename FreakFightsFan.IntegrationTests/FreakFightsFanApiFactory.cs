using FreakFightsFan.Api.Data.Database;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Testcontainers.MsSql;
using Xunit;

namespace FreakFightsFan.IntegrationTests
{
    public class FreakFightsFanApiFactory : WebApplicationFactory<Program>, IAsyncLifetime
    {
        private readonly MsSqlContainer _msSqlContainer = new MsSqlBuilder().Build();

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureTestServices(services =>
            {
                services.RemoveAll(typeof(AppDbContext));
                services.AddDbContext<AppDbContext>(x =>
                {
                    x.UseSqlServer(_msSqlContainer.GetConnectionString());
                });
            });
        }

        public Task InitializeAsync()
        {
            return _msSqlContainer.StartAsync();
        }

        Task IAsyncLifetime.DisposeAsync()
        {
            return _msSqlContainer.DisposeAsync().AsTask();
        }
    }
}
