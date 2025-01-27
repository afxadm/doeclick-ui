using Totem.Domain.Entities;
using Totem.Domain.View;

namespace Totem.Domain.Interfaces
{
    public interface IPositionRepository
    {
        Task<int> SavePosition(Positions positions);
        Task<PaginationViewModel<Positions>> GetPaginated(PaginationParams paginationParams);
        Task<Positions?> GetPositionById(Guid positionId);
    }
}
