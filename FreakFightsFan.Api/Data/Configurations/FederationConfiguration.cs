using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FreakFightsFan.Api.Data.Configurations
{
    public class FederationConfiguration : IEntityTypeConfiguration<Federation>
    {
        public void Configure(EntityTypeBuilder<Federation> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
