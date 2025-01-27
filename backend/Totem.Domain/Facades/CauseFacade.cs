using Totem.Domain.Entities;
using Totem.Domain.Interfaces;
using Totem.Domain.Interfaces.Facades;
using Totem.Domain.View;

namespace Totem.Domain.Facades
{
    public class CauseFacade : ICauseFacade
    {
        private readonly ICauseRepository _causeRepository;
        public CauseFacade(ICauseRepository causeRepository)
        {
            _causeRepository = causeRepository;
        }

        public async Task<bool> SaveCause(Causes causes)
        {
            if (await _causeRepository.SaveCause(causes) > 0)
                return true;

            return false;
        }

        public async Task<PaginationViewModel<Causes>> GetPaginated(PaginationParams paginationParams)
            => await _causeRepository.GetPaginated(paginationParams);
    }
}
