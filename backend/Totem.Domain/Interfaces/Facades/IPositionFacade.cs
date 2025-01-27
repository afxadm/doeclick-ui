using Totem.Domain.Entities;
using Totem.Domain.View;

namespace Totem.Domain.Interfaces.Facades
{
    public interface IPositionFacade
    {
        Task<bool> SavePosition(Positions positions);
        Task<PaginationViewModel<Positions>> GetPaginated(PaginationParams paginationParams);
        Task<Positions?> GetPositionById(Guid positionId);
    }
}
