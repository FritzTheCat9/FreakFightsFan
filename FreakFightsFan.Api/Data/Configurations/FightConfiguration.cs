using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FreakFightsFan.Api.Data.Configurations
{
    public class FightConfiguration : IEntityTypeConfiguration<Fight>
    {
        public void Configure(EntityTypeBuilder<Fight> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(f => f.Event)
                .WithMany(e => e.Fights)
                .HasForeignKey(f => f.EventId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(f => f.Teams)
                .WithOne(t => t.Fight)
                .HasForeignKey(t => t.FightId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
