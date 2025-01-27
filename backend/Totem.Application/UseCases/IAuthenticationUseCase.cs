using Totem.Domain;
using Totem.Domain.Dtos;

namespace Totem.Application.UseCases
{
    public interface IAuthenticationUseCase
    {
        Task<ResponseBase<object>> Login(AuthenticationDto authDto);
    }
}
