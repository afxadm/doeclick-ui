using Totem.Domain.Entities;
using Totem.Domain.View;

namespace Totem.Domain.Interfaces.Facades
{
    public interface IBranchFacade
    {
        Task<bool> SaveBranch(Branch branch);
        Task<PaginationViewModel<Branch>> GetPaginated(PaginationParams paginationParams);
        Task<Branch?> GetBranchById(Guid branchId);
    }
}
