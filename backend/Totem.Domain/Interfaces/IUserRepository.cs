using Totem.Domain.Entities;
using Totem.Domain.View;

namespace Totem.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<PaginationViewModel<Users>> GetUsers(PaginationParams paginationParams);
        Task<Users?> GetUserByCpf(string cpf);
        Task<int> SaveUser(Users user);
    }
}
