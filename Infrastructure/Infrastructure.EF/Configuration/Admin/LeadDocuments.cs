using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EF.Configuration
{
    public class LeadDocuments : IEntityTypeConfiguration<Core.Entities.LeadDocuments>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.LeadDocuments> builder)
        {
            builder.HasKey(p => new { p.Id });
            builder.HasOne(p => p.Document).WithMany().HasForeignKey(p => p.DocumentId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Lead).WithMany(p=>p.StoreImages).HasForeignKey(p => p.LeadId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}