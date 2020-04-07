using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EF.Configuration
{
    public class UserImage : IEntityTypeConfiguration<Core.Entities.UserImage>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.UserImage> builder)
        {
            builder.HasKey(p => new { p.Id });
            builder.HasOne(p => p.User).WithMany(p=>p.UserImages).HasForeignKey(p => p.UserId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Document).WithMany().HasForeignKey(p => p.DocumentId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}