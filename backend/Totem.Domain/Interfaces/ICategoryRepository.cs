using Totem.Domain.Entities;
using Totem.Domain.View;

namespace Totem.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Task<PaginationViewModel<Categories>> GetPaginated(PaginationParams paginationParams);
        Task<int> SaveCategory(Categories category);
    }
}
