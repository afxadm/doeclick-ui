using Totem.Domain.Dtos;
using Totem.Domain.Entities;
using Totem.Domain;
using Totem.Domain.View;

namespace Totem.Application.UseCases
{
    public interface IPositionUseCase
    {
        Task<ResponseBase<Positions>> SavePosition(PositionDto positionDto);
        Task<PaginationViewModel<Positions>> GetPaginated(PaginationParams paginationParams);
    }
}