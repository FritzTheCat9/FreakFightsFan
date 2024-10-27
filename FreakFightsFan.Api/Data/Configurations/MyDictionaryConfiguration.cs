using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FreakFightsFan.Api.Data.Configurations;

public class MyDictionaryConfiguration : IEntityTypeConfiguration<MyDictionary>
{
    public void Configure(EntityTypeBuilder<MyDictionary> builder)
    {
        builder.HasKey(d => d.Id);

        builder.HasMany(d => d.DictionaryItems)
            .WithOne(di => di.Dictionary)
            .HasForeignKey(di => di.DictionaryId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}