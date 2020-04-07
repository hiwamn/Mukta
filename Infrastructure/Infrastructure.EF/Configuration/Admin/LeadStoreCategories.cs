using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EF.Configuration
{
    public class LeadStoreCategories : IEntityTypeConfiguration<Core.Entities.LeadStoreCategories>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.LeadStoreCategories> builder)
        {
            builder.HasKey(p => new { p.Id });
            builder.HasOne(p => p.Lead).WithMany(p => p.StoreCategories).HasForeignKey(p => p.LeadId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}