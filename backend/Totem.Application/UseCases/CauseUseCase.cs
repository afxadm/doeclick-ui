using Totem.Domain;
using Totem.Domain.Dtos;
using Totem.Domain.Entities;
using Totem.Domain.Interfaces.Facades;
using Totem.Domain.View;

namespace Totem.Application.UseCases
{
    public class CauseUseCase : ICauseUseCase
    {
        private readonly ICauseFacade _causeFacade;

        public CauseUseCase(ICauseFacade causeFacade)
        {
            _causeFacade = causeFacade;
        }

        public async Task<ResponseBase<Causes>> SaveCause(CauseDto causeDto)
        {
            var cause = Causes.Of(causeDto);
            var saved = await _causeFacade.SaveCause(cause);

            return new ResponseBase<Causes>
            {
                Data = cause,
                IsSuccess = saved,
            };
        }

        public async Task<PaginationViewModel<Causes>> GetPaginated(PaginationParams paginationParams)
            => await _causeFacade.GetPaginated(paginationParams);
    }
}
