using Totem.Domain;
using Totem.Domain.Dtos;
using Totem.Domain.Entities;
using Totem.Domain.View;

namespace Totem.Application.UseCases
{
    public interface ICauseUseCase
    {
        Task<ResponseBase<Causes>> SaveCause(CauseDto causeDto);
        Task<PaginationViewModel<Causes>> GetPaginated(PaginationParams paginationParams);
    }
}