using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Totem.Domain;
using Totem.Domain.Dtos;
using Totem.Domain.Interfaces.Apis;

namespace Totem.Application.UseCases
{
    public class PaymentUseCase : IPaymentUseCase
    {
        private readonly IRequestPagbank _requestPagbank;

        public PaymentUseCase(IRequestPagbank request)
        {
            _requestPagbank = request;
        }

        public async Task<ResponseBase<object>> Payment(PaymentDto paymentDto)
        {
            var payment = await _requestPagbank.Payment(paymentDto);

            return payment;
        }
    }
}
