using Totem.Domain;
using Totem.Domain.Dtos;
using Totem.Domain.Entities;
using Totem.Domain.Interfaces.Facades;
using Totem.Domain.View;

namespace Totem.Application.UseCases
{
    public class TaxpayerUseCase : ITaxpayerUseCase
    {
        private readonly ITaxpayerFacade _taxpayerFacade;

        public TaxpayerUseCase(ITaxpayerFacade taxpayerFacade)
        {
            _taxpayerFacade = taxpayerFacade;
        }

        public async Task<ResponseBase<Taxpayers>> SaveTaxpayer(TaxpayerDto taxpayerDto)
        {
            var taxpayer = Taxpayers.Of(taxpayerDto);
            var saved = await _taxpayerFacade.SaveTaxpayer(taxpayer);

            return new ResponseBase<Taxpayers>()
            {
                Data = taxpayer,
                IsSuccess = saved
            };
        }

        public async Task<PaginationViewModel<Taxpayers>> GetPaginated(PaginationParams paginationParams)
            => await _taxpayerFacade.GetPaginated(paginationParams);
    }
}
