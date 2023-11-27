using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FreakFightsFan.Api.Data.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Fighter> Fighters { get; set; }
        public DbSet<Federation> Federations { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Fight> Fights { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<MyDictionary> MyDictionaries { get; set; }
        public DbSet<MyDictionaryItem> MyDictionaryItems { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
