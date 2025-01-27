using Totem.Domain.Entities;
using Totem.Domain.View;

namespace Totem.Domain.Interfaces
{
    public interface ICategoryFacade
    {
        Task<PaginationViewModel<Categories>> GetPaginated(PaginationParams paginationParams);
        Task<bool> SaveCategory(Categories category);
    }
}