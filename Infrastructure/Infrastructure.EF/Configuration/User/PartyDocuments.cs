using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EF.Configuration
{
    public class PartyDocuments : IEntityTypeConfiguration<Core.Entities.PartyDocuments>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.PartyDocuments> builder)
        {
            builder.HasKey(p => new { p.Id });
            builder.HasOne(p => p.Document).WithMany().HasForeignKey(p => p.DocumentId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Party).WithMany(p=>p.StoreImages).HasForeignKey(p => p.PartyId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}