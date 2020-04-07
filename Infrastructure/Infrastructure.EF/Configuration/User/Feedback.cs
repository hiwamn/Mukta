using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EF.Configuration
{
    public class Feedback : IEntityTypeConfiguration<Core.Entities.Feedback>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.Feedback> builder)
        {
            builder.HasKey(p => new { p.Id });
            builder.HasOne(p => p.Status).WithMany(p => p.Feedback).HasForeignKey(p => p.StatusId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Party).WithMany(p=>p.Feedback).HasForeignKey(p => p.PartyId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}