using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Totem.Domain.Entities;

namespace Totem.Infrastructure.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable("User");

            builder.HasKey(x => x.Id);

            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Cpf).IsRequired().HasMaxLength(11);
            builder.Property(p => p.Telephone).HasMaxLength(20);
            builder.Property(p => p.Email).IsRequired().HasMaxLength(250);
            builder.Property(p => p.Password).IsRequired().HasMaxLength(250);
            builder.Property(p => p.TypeUser);
            builder.Property(p => p.Active).IsRequired();
            builder.Property(p => p.CreatedAt);
            builder.Property(p => p.UpdatedAt);

            builder.HasOne(p => p.Branch)
                .WithMany(p => p.Users)
                .HasForeignKey(x => x.BranchId);

            builder.HasOne(p => p.Position)
                .WithMany(p => p.Users)
                .HasForeignKey(p => p.PositionId);
        }
    }
}
