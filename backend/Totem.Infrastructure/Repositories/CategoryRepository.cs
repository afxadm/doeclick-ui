using Microsoft.EntityFrameworkCore;
using Totem.Domain;
using Totem.Domain.Entities;
using Totem.Domain.Interfaces;
using Totem.Domain.View;
using Totem.Infrastructure.Data;
using Totem.Infrastructure.Repositories.Utils;

namespace Totem.Infrastructure.Repositories
{
    public class CategoryRepository : Repository<Categories, long>, ICategoryRepository
    {
        public CategoryRepository(TotemContext context) : base(context)
        {
        }

        public async Task<int> SaveCategory(Categories category)
        {
            await _context.AddAsync(category);
            return await _context.SaveChangesAsync();
        }

        public async Task<PaginationViewModel<Categories>> GetPaginated(PaginationParams paginationParams)
        {
            var query = _set.AsQueryable();

            var totalItems = await query.CountAsync();

            var data = await query.Paginate(paginationParams).ToListAsync();

            return new PaginationViewModel<Categories>
            {
                Data = data,
                TotalItems = totalItems,
            };
        }
    }
}
