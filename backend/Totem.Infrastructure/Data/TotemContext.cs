using Microsoft.EntityFrameworkCore;
using Totem.Infrastructure.Mappings;

namespace Totem.Infrastructure.Data
{
    public class TotemContext : DbContext
    {
        public TotemContext(DbContextOptions<TotemContext> opts) : base(opts)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("DefaultConnection");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMapping());
            modelBuilder.ApplyConfiguration(new BranchMapping());
            modelBuilder.ApplyConfiguration(new PositionsMapping());
            modelBuilder.ApplyConfiguration(new CategoriesMapping());
            modelBuilder.ApplyConfiguration(new CausesMapping());
            modelBuilder.ApplyConfiguration(new OperationsMapping());
            modelBuilder.ApplyConfiguration(new TaxpayersMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
