using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FreakFightsFan.Api.Data.Configurations
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasOne(e => e.Federation)
                .WithMany(f => f.Events)
                .HasForeignKey(e => e.FederationId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.City)
                .WithMany(di => di.Events)
                .HasForeignKey(e => e.CityId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(e => e.Fights)
                .WithOne(f => f.Event)
                .HasForeignKey(f => f.EventId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
