using Totem.Domain;
using Totem.Domain.Dtos;

namespace Totem.Application.UseCases
{
    public interface IPaymentUseCase
    {
        Task<ResponseBase<object>> Payment(PaymentDto paymentDto);
    }
}