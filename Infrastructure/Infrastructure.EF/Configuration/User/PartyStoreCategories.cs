using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EF.Configuration
{
    public class PartyStoreCategories : IEntityTypeConfiguration<Core.Entities.PartyStoreCategories>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.PartyStoreCategories> builder)
        {
            builder.HasKey(p => new { p.Id });
        }
    }
}