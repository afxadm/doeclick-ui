using Totem.Domain;
using Totem.Domain.Dtos;
using Totem.Domain.Entities;
using Totem.Domain.View;

namespace Totem.Application.UseCases
{
    public interface IUserUseCase
    {
        Task<PaginationViewModel<Users>> GetPaginated(PaginationParams paginationParams);
        Task<ResponseBase<object>> SaveUser(UserDto user);
    }
}
