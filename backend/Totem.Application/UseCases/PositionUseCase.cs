using Totem.Domain;
using Totem.Domain.Dtos;
using Totem.Domain.Entities;
using Totem.Domain.Interfaces.Facades;
using Totem.Domain.View;

namespace Totem.Application.UseCases
{
    public class PositionUseCase : IPositionUseCase
    {
        private readonly IPositionFacade _positionFacade;

        public PositionUseCase(IPositionFacade positionFacade)
        {
            _positionFacade = positionFacade;
        }

        public async Task<ResponseBase<Positions>> SavePosition(PositionDto positionDto)
        {
            var position = Positions.Of(positionDto);

            var saved = await _positionFacade.SavePosition(position);

            return new ResponseBase<Positions>()
            {
                IsSuccess = saved,
                Data = position
            };
        }

        public async Task<PaginationViewModel<Positions>> GetPaginated(PaginationParams paginationParams)
            => await _positionFacade.GetPaginated(paginationParams);
    }
}
