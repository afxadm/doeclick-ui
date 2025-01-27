using Totem.Domain;
using Totem.Domain.Dtos;
using Totem.Domain.Entities;
using Totem.Domain.View;

namespace Totem.Application.UseCases
{
    public interface ICategoryUseCase
    {
        Task<PaginationViewModel<Categories>> GetPaginated(PaginationParams paginationParams);
        Task<ResponseBase<Categories>> SaveCategory(CategoryDto category);
    }
}