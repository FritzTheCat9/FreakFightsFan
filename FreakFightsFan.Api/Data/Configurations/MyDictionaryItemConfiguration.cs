using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FreakFightsFan.Api.Data.Configurations
{
    public class MyDictionaryItemConfiguration : IEntityTypeConfiguration<MyDictionaryItem>
    {
        public void Configure(EntityTypeBuilder<MyDictionaryItem> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Dictionary)
                .WithMany(x => x.DictionaryItems)
                .HasForeignKey(x => x.DictionaryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
