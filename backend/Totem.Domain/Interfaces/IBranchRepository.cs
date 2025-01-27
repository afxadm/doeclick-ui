using Totem.Domain.Entities;
using Totem.Domain.View;

namespace Totem.Domain.Interfaces
{
    public interface IBranchRepository
    {
        Task<int> SaveBranch(Branch branch);
        Task<PaginationViewModel<Branch>> GetPaginated(PaginationParams paginationParams);
        Task<Branch?> GetBranchById(Guid branchId);
    }
}
