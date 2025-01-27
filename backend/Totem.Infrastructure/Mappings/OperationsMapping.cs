using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Totem.Domain.Entities;

namespace Totem.Infrastructure.Mappings
{
    internal class OperationsMapping : IEntityTypeConfiguration<Operations>
    {
        public void Configure(EntityTypeBuilder<Operations> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.QuantityCauses);
            builder.Property(p => p.ValueTotalCauses);
            builder.Property(p => p.ValueTotalOperation);
            builder.Property(p => p.PaymentMethod)
                .IsRequired();

            builder.Property(p => p.DateOperation)
                .IsRequired()
                .HasColumnType("date");

            builder.Property(p => p.HourOperation)
                .IsRequired()
                .HasColumnType("time(7)");

            builder.Property(p => p.Comments);
            builder.Property(p => p.CreatedAt);
            builder.Property(p => p.UpdatedAt);

            //builder.HasMany(p => p.Causes)
            //    .WithOne(p => p.Operation)
            //    .HasForeignKey(p => p.Id);

            builder.HasOne(p => p.Taxpayer)
                .WithOne(p => p.Operation)
                .HasForeignKey<Operations>(p => p.TaxpayerId);

            builder.HasOne(p => p.Branch)
                .WithOne(p => p.Operation)
                .HasForeignKey<Operations>(p => p.BranchId);

        }
    }
}
