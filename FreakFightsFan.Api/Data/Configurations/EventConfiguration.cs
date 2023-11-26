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
        }
    }
}
