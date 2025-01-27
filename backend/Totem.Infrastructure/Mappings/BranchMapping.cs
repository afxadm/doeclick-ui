using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Totem.Domain.Entities;

namespace Totem.Infrastructure.Mappings
{
    public class BranchMapping : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.ToTable("Branch");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.NameBranch)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Address)
                .HasMaxLength(250);

            builder.Property(p => p.Telephone)
                .HasMaxLength(20);

            builder.Property(p => p.Active)
                .IsRequired();

            builder.Property(p => p.CreatedAt);
            builder.Property(p => p.UpdatedAt);

            builder.Property(p => p.CodeBranch)
                .IsRequired()
                .HasMaxLength(6);

            builder.HasIndex(p => p.CodeBranch)
                .IsUnique();
        }
    }
}
