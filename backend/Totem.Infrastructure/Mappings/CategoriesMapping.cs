using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Totem.Domain.Entities;

namespace Totem.Infrastructure.Mappings
{
    public class CategoriesMapping : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Description)
                .IsRequired();

            builder.Property(p => p.Active)
                .IsRequired();

            builder.Property(p => p.CreatedAt);
            builder.Property(p => p.UpdatedAt);
        }
    }
}
