using Microsoft.EntityFrameworkCore;
using Totem.Domain;
using Totem.Domain.Entities;
using Totem.Domain.Interfaces;
using Totem.Domain.View;
using Totem.Infrastructure.Data;
using Totem.Infrastructure.Repositories.Utils;

namespace Totem.Infrastructure.Repositories
{
    public class CauseRepository : Repository<Causes, long>, ICauseRepository
    {
        public CauseRepository(TotemContext context) : base(context)
        {
        }

        public async Task<int> SaveCause(Causes cause)
        {
            await _context.AddAsync(cause);
            return await _context.SaveChangesAsync();
        }

        public async Task<PaginationViewModel<Causes>> GetPaginated(PaginationParams paginationParams)
        {
            var query = _set.AsQueryable();

            var totalItems = await query.CountAsync();

            var data = await query.Paginate(paginationParams).ToListAsync();

            return new PaginationViewModel<Causes>
            {
                Data = data,
                TotalItems = totalItems
            };
        }
    }
}
