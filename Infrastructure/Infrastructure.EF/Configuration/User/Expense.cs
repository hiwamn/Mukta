using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EF.Configuration
{
    public class Expense : IEntityTypeConfiguration<Core.Entities.Expense>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.Expense> builder)
        {
            builder.HasKey(p => new { p.Id });
        }
    }
}