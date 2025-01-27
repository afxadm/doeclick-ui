using Totem.Domain.Dtos;
using Totem.Domain.Entities;
using Totem.Domain;
using Totem.Domain.View;

namespace Totem.Application.UseCases
{
    public interface IBranchUseCase
    {
        Task<ResponseBase<Branch>> SaveBranch(BranchDto branchDto);
        Task<PaginationViewModel<Branch>> GetPaginated(PaginationParams paginationParams);
    }
}