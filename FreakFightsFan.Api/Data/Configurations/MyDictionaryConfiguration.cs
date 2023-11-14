using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FreakFightsFan.Api.Data.Configurations
{
    public class MyDictionaryConfiguration : IEntityTypeConfiguration<MyDictionary>
    {
        public void Configure(EntityTypeBuilder<MyDictionary> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.DictionaryItems)
                .WithOne(x => x.Dictionary)
                .HasForeignKey(x => x.DictionaryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
