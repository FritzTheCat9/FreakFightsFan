using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FreakFightsFan.Api.Data.Configurations
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Federation)
                .WithMany(x => x.Events)
                .HasForeignKey(x => x.FederationId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
