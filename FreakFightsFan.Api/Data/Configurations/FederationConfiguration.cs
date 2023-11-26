using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FreakFightsFan.Api.Data.Configurations
{
    public class FederationConfiguration : IEntityTypeConfiguration<Federation>
    {
        public void Configure(EntityTypeBuilder<Federation> builder)
        {
            builder.HasKey(f => f.Id);

            builder.HasMany(f => f.Events)
                .WithOne(e => e.Federation)
                .HasForeignKey(e => e.FederationId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(f => f.Image)
                .WithOne(i => i.Federation)
                .HasForeignKey<Image>(i => i.FederationId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
