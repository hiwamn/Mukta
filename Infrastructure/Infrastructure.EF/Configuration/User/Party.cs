using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EF.Configuration
{
    public class Party : IEntityTypeConfiguration<Core.Entities.Party>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.Party> builder)
        {
            builder.HasKey(p => new { p.Id });
            
        }
    }
}