using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EF.Configuration
{
    public class ExpenseCategory : IEntityTypeConfiguration<Core.Entities.ExpenseCategory>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.ExpenseCategory> builder)
        {
            builder.HasKey(p => new { p.Id });
        }
    }
}