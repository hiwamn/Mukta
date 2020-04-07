using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EF.Configuration
{
    public class PartyType : IEntityTypeConfiguration<Core.Entities.PartyType>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.PartyType> builder)
        {
            builder.HasKey(p => new { p.Id });
            builder.Property(p => p.Id ).ValueGeneratedNever();
        }
    }
}