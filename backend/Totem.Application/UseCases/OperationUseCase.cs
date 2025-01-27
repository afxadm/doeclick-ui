using Totem.Domain;
using Totem.Domain.Dtos;
using Totem.Domain.Entities;
using Totem.Domain.Interfaces.Facades;
using Totem.Domain.View;

namespace Totem.Application.UseCases
{
    public class OperationUseCase : IOperationUseCase
    {
        private readonly IOperationFacade _operationFacade;

        public OperationUseCase(IOperationFacade operationFacade)
        {
            _operationFacade = operationFacade;
        }

        public async Task<ResponseBase<Operations>> SaveOperation(OperationDto operationDto)
        {
            var operation = Operations.Of(operationDto);
            var saved = await _operationFacade.SaveOperation(operation);

            return new ResponseBase<Operations>()
            {
                Data = operation,
                IsSuccess = saved,
            };
        }

        public async Task<PaginationViewModel<Operations>> GetPaginated(PaginationParams paginationParams)
            => await _operationFacade.GetPaginated(paginationParams);
    }
}
