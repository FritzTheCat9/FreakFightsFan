using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FreakFightsFan.Api.Data.Configurations
{
    public class FighterConfiguration : IEntityTypeConfiguration<Fighter>
    {
        public void Configure(EntityTypeBuilder<Fighter> builder)
        {
            builder.HasKey(f => f.Id);

            builder.HasOne(f => f.Image)
                .WithOne(i => i.Fighter)
                .HasForeignKey<Image>(i => i.FighterId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(f => f.Teams)
                .WithMany(t => t.Fighters)
                .UsingEntity<TeamFighter>();
        }
    }
}
