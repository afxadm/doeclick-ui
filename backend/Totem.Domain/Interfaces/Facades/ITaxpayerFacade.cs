using Totem.Domain.Entities;
using Totem.Domain.View;

namespace Totem.Domain.Interfaces.Facades
{
    public interface ITaxpayerFacade
    {
        Task<PaginationViewModel<Taxpayers>> GetPaginated(PaginationParams paginationParams);
        Task<bool> SaveTaxpayer(Taxpayers taxpayers);
    }
}
