using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FreakFightsFan.Api.Data.Configurations
{
    public class FightConfiguration : IEntityTypeConfiguration<Fight>
    {
        public void Configure(EntityTypeBuilder<Fight> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
