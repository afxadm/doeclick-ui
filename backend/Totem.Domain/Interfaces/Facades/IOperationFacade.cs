using Totem.Domain.Entities;
using Totem.Domain.View;

namespace Totem.Domain.Interfaces.Facades
{
    public interface IOperationFacade
    {
        Task<bool> SaveOperation(Operations operations);
        Task<PaginationViewModel<Operations>> GetPaginated(PaginationParams paginationParams);
    }
}
