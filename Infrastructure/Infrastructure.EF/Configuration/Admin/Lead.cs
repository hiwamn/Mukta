using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EF.Configuration
{
    public class Lead : IEntityTypeConfiguration<Core.Entities.Lead>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.Lead> builder)
        {
            builder.HasKey(p => new { p.Id });
            builder.HasOne(p=>p.User).WithMany(p=>p.Lead).HasForeignKey(p=>p.UserId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}