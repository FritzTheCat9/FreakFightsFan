using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FreakFightsFan.Api.Data.Configurations
{
    public class MyDictionaryItemConfiguration : IEntityTypeConfiguration<MyDictionaryItem>
    {
        public void Configure(EntityTypeBuilder<MyDictionaryItem> builder)
        {
            builder.HasKey(di => di.Id);

            builder.HasOne(di => di.Dictionary)
                   .WithMany(d => d.DictionaryItems)
                   .HasForeignKey(di => di.DictionaryId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(di => di.Events_Cities)
                   .WithOne(e => e.City)
                   .HasForeignKey(e => e.CityId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(di => di.Events_Halls)
                   .WithOne(e => e.Hall)
                   .HasForeignKey(e => e.HallId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(di => di.Fights_Types)
                   .WithOne(f => f.Type)
                   .HasForeignKey(f => f.TypeId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
