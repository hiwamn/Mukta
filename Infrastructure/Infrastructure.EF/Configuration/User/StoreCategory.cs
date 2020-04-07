using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EF.Configuration
{
    public class StoreCategory : IEntityTypeConfiguration<Core.Entities.StoreCategory>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.StoreCategory> builder)
        {
            builder.HasKey(p => new { p.Id });
        }
    }
}