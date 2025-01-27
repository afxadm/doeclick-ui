using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Totem.Domain.Entities;

namespace Totem.Infrastructure.Mappings
{
    public class CausesMapping : IEntityTypeConfiguration<Causes>
    {
        public void Configure(EntityTypeBuilder<Causes> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Description)
                .IsRequired();

            builder.Property(p => p.CauseType);
            builder.Property(p => p.Active);
            builder.Property(p => p.Value);
            builder.Property(p => p.Goal);
            builder.Property(p => p.ValueGoal);
            builder.Property(p => p.Observations);
            builder.Property(p => p.TokenPagBank);
            builder.Property(p => p.CreatedAt);
            builder.Property(p => p.UpdatedAt);

            builder.HasOne(p => p.Category)
                .WithOne(p => p.Causes)
                .HasForeignKey<Causes>(p => p.CategoryId);
        }
    }
}
