using Totem.Domain.Entities;
using Totem.Domain.View;

namespace Totem.Domain.Interfaces
{
    public interface ICauseRepository
    {
        Task<PaginationViewModel<Causes>> GetPaginated(PaginationParams paginationParams);
        Task<int> SaveCause(Causes cause);
    }
}
