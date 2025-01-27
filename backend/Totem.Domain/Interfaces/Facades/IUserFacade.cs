using Totem.Domain.Entities;
using Totem.Domain.View;

namespace Totem.Domain.Interfaces.Facades
{
    public interface IUserFacade
    {
        Task<PaginationViewModel<Users>> GetPaginated(PaginationParams paginationParams);
        Task<Users?> GetUserByCpf(string cpf);
        Task<bool> SaveUser(Users user);
    }
}
