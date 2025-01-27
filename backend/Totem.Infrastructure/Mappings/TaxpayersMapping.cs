using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Totem.Domain.Entities;

namespace Totem.Infrastructure.Mappings
{
    public class TaxpayersMapping : IEntityTypeConfiguration<Taxpayers>
    {
        public void Configure(EntityTypeBuilder<Taxpayers> builder) 
        { 
            builder.HasKey(p => p.Id);
            
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Cpf).IsRequired().HasMaxLength(11);
            builder.Property(p => p.Telephone);
            builder.Property(p => p.Worker);
            builder.Property(p => p.Registration);
            builder.Property(p => p.Active);
            builder.Property(p => p.Address);
            builder.Property(p => p.CreatedAt);
            builder.Property(p => p.UpdatedAt);

            builder.HasOne(p => p.Branch)
                .WithMany(p => p.Taxpayers)
                .HasForeignKey(x => x.BranchId);


        }
    }
}
