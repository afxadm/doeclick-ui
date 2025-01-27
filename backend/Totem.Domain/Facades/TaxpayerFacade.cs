using Totem.Domain.Entities;
using Totem.Domain.Interfaces;
using Totem.Domain.Interfaces.Facades;
using Totem.Domain.View;

namespace Totem.Domain.Facades
{
    public class TaxpayerFacade : ITaxpayerFacade
    {
        private readonly ITaxpayerRepository _taxpayerRepository;

        public TaxpayerFacade(ITaxpayerRepository taxpayerRepository)
        {
            _taxpayerRepository = taxpayerRepository;
        }

        public async Task<bool> SaveTaxpayer(Taxpayers taxpayers)
        {
            if (await _taxpayerRepository.SaveTaxpayer(taxpayers) > 0)
                return true;

            return false;
        }

        public async Task<PaginationViewModel<Taxpayers>> GetPaginated(PaginationParams paginationParams)
            => await _taxpayerRepository.GetPaginated(paginationParams);
    }
}
