using Totem.Domain.Interfaces;
using Totem.Domain.Entities;
using Totem.Infrastructure.Data;
using Totem.Domain;
using Totem.Infrastructure.Repositories.Utils;
using Totem.Domain.View;
using Microsoft.EntityFrameworkCore;

namespace Totem.Infrastructure.Repositories
{
    public class UserRepository : Repository<Users, long>, IUserRepository
    {
        public UserRepository(TotemContext context) : base(context)
        {
        }


        public async Task<PaginationViewModel<Users>> GetUsers(PaginationParams paginationParams)
        {
            var query = _set.AsQueryable();

            var totalItems = await query.CountAsync();

            var data = await query.Paginate(paginationParams).ToListAsync();

            return new PaginationViewModel<Users>
            {
                Data = data,
                TotalItems = totalItems
            };
        }

        public async Task<Users?> GetUserByCpf(string cpf)
            => await _set.FirstOrDefaultAsync(x => x.Cpf == cpf);

        public async Task<int> SaveUser(Users user)
        {
            await _set.AddAsync(user);
            return await _context.SaveChangesAsync();
        }
    }
}
