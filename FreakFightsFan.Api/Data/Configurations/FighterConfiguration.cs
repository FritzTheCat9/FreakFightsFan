using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FreakFightsFan.Api.Data.Configurations
{
    public class FighterConfiguration : IEntityTypeConfiguration<Fighter>
    {
        public void Configure(EntityTypeBuilder<Fighter> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
