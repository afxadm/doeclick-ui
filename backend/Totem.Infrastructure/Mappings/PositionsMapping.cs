using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Totem.Domain.Entities;

namespace Totem.Infrastructure.Mappings
{
    public class PositionsMapping : IEntityTypeConfiguration<Positions>
    {
        public void Configure(EntityTypeBuilder<Positions> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Active).IsRequired();
            builder.Property(p => p.CreatedAt);
            builder.Property(p => p.UpdatedAt);
            
            builder.Property(p => p.Description)
                .IsRequired();

            builder.HasIndex(p => p.Description)
                .IsUnique();
        }
    }
}
