using Microsoft.EntityFrameworkCore;
using Totem.Domain;
using Totem.Domain.Entities;
using Totem.Domain.Interfaces;
using Totem.Domain.View;
using Totem.Infrastructure.Data;
using Totem.Infrastructure.Repositories.Utils;

namespace Totem.Infrastructure.Repositories
{
    public class TaxpayerRepository : Repository<Taxpayers, long>, ITaxpayerRepository
    {
        public TaxpayerRepository(TotemContext context) : base(context)
        {
        }

        public async Task<int> SaveTaxpayer(Taxpayers taxpayer)
        {
            await _context.AddAsync(taxpayer);
            return await _context.SaveChangesAsync();
        }

         public async Task<PaginationViewModel<Taxpayers>> GetPaginated(PaginationParams paginationParams)
        {
            var query = _set.AsQueryable();

            var totalItems = await _set.CountAsync();

            var data = await query.Paginate(paginationParams).ToListAsync();

            return new PaginationViewModel<Taxpayers>
            {
                Data = data,
                TotalItems = totalItems
            };
        }
    }
}
