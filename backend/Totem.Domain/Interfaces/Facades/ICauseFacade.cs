using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Totem.Domain.Entities;
using Totem.Domain.View;

namespace Totem.Domain.Interfaces.Facades
{
    public interface ICauseFacade
    {
        Task<PaginationViewModel<Causes>> GetPaginated(PaginationParams paginationParams);
        Task<bool> SaveCause(Causes causes);
    }
}
