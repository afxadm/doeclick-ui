using Totem.Domain.Entities;
using Totem.Domain.Interfaces;
using Totem.Domain.Interfaces.Facades;
using Totem.Domain.View;

namespace Totem.Domain.Facades
{
    public class OperationFacade : IOperationFacade
    {
        private readonly IOperationRepository _operationRepository;

        public OperationFacade(IOperationRepository operationRepository)
        {
            _operationRepository = operationRepository;
        }

        public async Task<bool> SaveOperation(Operations operations)
        {
            if (await _operationRepository.SaveOperation(operations) > 0)
                return true;

            return false;
        }

        public async Task<PaginationViewModel<Operations>> GetPaginated(PaginationParams paginationParams)
            => await _operationRepository.GetPaginated(paginationParams);
    }
}
