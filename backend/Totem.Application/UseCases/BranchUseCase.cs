using Totem.Domain;
using Totem.Domain.Dtos;
using Totem.Domain.Entities;
using Totem.Domain.Interfaces.Facades;
using Totem.Domain.View;

namespace Totem.Application.UseCases
{
    public class BranchUseCase : IBranchUseCase
    {
        private readonly IBranchFacade _branchFacade;

        public BranchUseCase(IBranchFacade branchFacade)
        {
            _branchFacade = branchFacade;
        }

        public async Task<ResponseBase<Branch>> SaveBranch(BranchDto branchDto)
        {
            var branch = Branch.Of(branchDto);
            var saved = await _branchFacade.SaveBranch(branch);

            return new ResponseBase<Branch>() 
            { 
                Data = branch,
                IsSuccess = saved
            };
        }

        public async Task<PaginationViewModel<Branch>> GetPaginated(PaginationParams paginationParams)
            => await _branchFacade.GetPaginated(paginationParams);
    }
}
