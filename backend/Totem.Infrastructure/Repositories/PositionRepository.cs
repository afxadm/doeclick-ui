using Microsoft.EntityFrameworkCore;
using Totem.Domain;
using Totem.Domain.Entities;
using Totem.Domain.Interfaces;
using Totem.Domain.View;
using Totem.Infrastructure.Data;
using Totem.Infrastructure.Repositories.Utils;

namespace Totem.Infrastructure.Repositories
{
    public class PositionRepository : Repository<Positions, long>, IPositionRepository
    {
        public PositionRepository(TotemContext context) : base(context)
        {
        }

        public async Task<int> SavePosition(Positions positions)
        {
            await _context.AddAsync(positions);
            return await _context.SaveChangesAsync();
        }

        public async Task<Positions?> GetPositionById(Guid positionId)
            => await _set.FirstOrDefaultAsync(x => x.Id == positionId);

        public async Task<PaginationViewModel<Positions>> GetPaginated(PaginationParams paginationParams)
        {
            var query = _set.AsQueryable();

            var totalItems = await _set.CountAsync();

            var data = await query.Paginate(paginationParams).ToListAsync();

            return new PaginationViewModel<Positions>
            {
                Data = data,
                TotalItems = totalItems
            };
        }
    }
}
