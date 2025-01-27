using Microsoft.EntityFrameworkCore;
using Totem.Domain;
using Totem.Domain.Entities;
using Totem.Domain.Interfaces;
using Totem.Domain.View;
using Totem.Infrastructure.Data;
using Totem.Infrastructure.Repositories.Utils;

namespace Totem.Infrastructure.Repositories
{
    public class BranchRepository : Repository<Branch, long>, IBranchRepository
    {
        public BranchRepository(TotemContext context) : base(context)
        {
        }

        public async Task<int> SaveBranch(Branch branch)
        {
            await _context.AddAsync(branch);
            return await _context.SaveChangesAsync();
        }

        public async Task<Branch?> GetBranchById(Guid branchId)
            => await _set.FirstOrDefaultAsync(x => x.Id == branchId);

        public async Task<PaginationViewModel<Branch>> GetPaginated(PaginationParams paginationParams)
        {
            var query = _set.AsQueryable();

            var totalItems = await query.CountAsync();

            var data = await query.Paginate(paginationParams).ToListAsync();

            return new PaginationViewModel<Branch>
            {
                Data = data,
                TotalItems = totalItems
            };
        }
    }
}
