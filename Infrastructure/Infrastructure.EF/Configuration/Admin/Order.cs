using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EF.Configuration
{
    public class Order : IEntityTypeConfiguration<Core.Entities.Order>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.Order> builder)
        {
            builder.HasKey(p => new { p.Id });
            builder.HasOne(p => p.Party).WithMany(p => p.Order).HasForeignKey(p => p.PartyId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}