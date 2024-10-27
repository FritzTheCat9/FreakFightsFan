using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FreakFightsFan.Api.Data.Configurations;

public class TeamFighterConfiguration : IEntityTypeConfiguration<TeamFighter>
{
    public void Configure(EntityTypeBuilder<TeamFighter> builder)
    {
        builder.HasKey(tf => tf.Id);
    }
}