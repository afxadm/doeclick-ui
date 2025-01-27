using Totem.Domain.Entities;
using Totem.Domain.Interfaces;
using Totem.Domain.Interfaces.Facades;
using Totem.Domain.View;

namespace Totem.Domain.Facades
{
    public class BranchFacade : IBranchFacade
    {
        private readonly IBranchRepository _branchRepository;

        public BranchFacade(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
        }

        public async Task<bool> SaveBranch(Branch branch)
        {
            if (await _branchRepository.SaveBranch(branch) > 0)
                return true;

            return false;
        }

        public async Task<PaginationViewModel<Branch>> GetPaginated(PaginationParams paginationParams)
            => await _branchRepository.GetPaginated(paginationParams);

        public async Task<Branch?> GetBranchById(Guid branchId)
            => await _branchRepository.GetBranchById(branchId);

    }
}
