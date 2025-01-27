using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Totem.Domain.Entities;
using Totem.Domain.Interfaces;
using Totem.Domain.Interfaces.Facades;
using Totem.Domain.View;

namespace Totem.Domain.Facades
{
    public class PositionFacade : IPositionFacade
    {
        private readonly IPositionRepository _positionRepository;

        public PositionFacade(IPositionRepository positionRepository)
        {
            _positionRepository = positionRepository;
        }

        public async Task<bool> SavePosition(Positions positions)
        {
            if (await _positionRepository.SavePosition(positions) > 0)
                return true;

            return false;
        }

        public async Task<PaginationViewModel<Positions>> GetPaginated(PaginationParams paginationParams)
            => await _positionRepository.GetPaginated(paginationParams);

        public async Task<Positions?> GetPositionById(Guid positionId)
            => await _positionRepository.GetPositionById(positionId);
    }
}
