using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FreakFightsFan.Api.Data.Configurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(t => t.Fight)
                   .WithMany(f => f.Teams)
                   .HasForeignKey(t => t.FightId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(t => t.Fighters)
                   .WithMany(f => f.Teams)
                   .UsingEntity<TeamFighter>();
        }
    }
}
