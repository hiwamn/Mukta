using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EF.Configuration
{
    public class OrderDocuments : IEntityTypeConfiguration<Core.Entities.OrderDocuments>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.OrderDocuments> builder)
        {
            builder.HasKey(p => new { p.Id });
            builder.HasOne(p => p.Document).WithMany().HasForeignKey(p => p.DocumentId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Order).WithMany(p=>p.InvoiceImages).HasForeignKey(p=>p.OrderId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}