using Totem.Domain.Entities;
using Totem.Domain.View;

namespace Totem.Domain.Interfaces
{
    public interface ITaxpayerRepository
    {
        Task<int> SaveTaxpayer(Taxpayers taxpayer);
        Task<PaginationViewModel<Taxpayers>> GetPaginated(PaginationParams paginationParams);
    }
}
