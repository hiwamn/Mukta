using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EF.Configuration
{
    public class ProductCategory : IEntityTypeConfiguration<Core.Entities.ProductCategory>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.ProductCategory> builder)
        {
            builder.HasKey(p => new { p.Id });
        }
    }
}