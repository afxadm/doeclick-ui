using Totem.Domain.Dtos;
using Totem.Domain.Entities;
using Totem.Domain;
using Totem.Domain.View;

namespace Totem.Application.UseCases
{
    public interface ITaxpayerUseCase
    {
        Task<ResponseBase<Taxpayers>> SaveTaxpayer(TaxpayerDto taxpayerDto);
        Task<PaginationViewModel<Taxpayers>> GetPaginated(PaginationParams paginationParams);
    }
}