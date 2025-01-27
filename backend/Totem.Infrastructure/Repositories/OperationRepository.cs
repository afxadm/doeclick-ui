using Microsoft.EntityFrameworkCore;
using Totem.Domain;
using Totem.Domain.Entities;
using Totem.Domain.Interfaces;
using Totem.Domain.View;
using Totem.Infrastructure.Data;
using Totem.Infrastructure.Repositories.Utils;

namespace Totem.Infrastructure.Repositories
{
    public class OperationRepository : Repository<Operations, long>, IOperationRepository
    {
        public OperationRepository(TotemContext context) : base(context)
        {
        }

        public async Task<int> SaveOperation(Operations operations)
        {
            await _context.AddAsync(operations);
            return await _context.SaveChangesAsync();
        }

        public async Task<PaginationViewModel<Operations>> GetPaginated(PaginationParams paginationParams)
        {
            var query = _set.AsQueryable();

            var totalItems = await query.CountAsync();

            var data = await query.Paginate(paginationParams).ToListAsync();

            return new PaginationViewModel<Operations>
            {
                Data = data,
                TotalItems = totalItems,
            };
        }
    }
}
