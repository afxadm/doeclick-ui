using Totem.Domain.Entities;
using Totem.Domain.View;

namespace Totem.Domain.Interfaces
{
    public interface IOperationRepository
    {
        Task<int> SaveOperation(Operations operations);
        Task<PaginationViewModel<Operations>> GetPaginated(PaginationParams paginationParams);
    }
}
