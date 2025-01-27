using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Totem.Domain.Dtos;

namespace Totem.Domain.Interfaces.Apis
{
    public interface IRequestPagbank
    {
        Task<ResponseBase<object>> Payment(PaymentDto paymentDto);
    }
}
