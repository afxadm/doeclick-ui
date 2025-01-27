using Totem.Domain.Dtos;
using Totem.Domain.Entities;
using Totem.Domain;
using Totem.Domain.View;

namespace Totem.Application.UseCases
{
    public interface IOperationUseCase
    {
        Task<ResponseBase<Operations>> SaveOperation(OperationDto operationDto);
        Task<PaginationViewModel<Operations>> GetPaginated(PaginationParams paginationParams);
    }
}