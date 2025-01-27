using Totem.Domain.Abstractions.Base;
using Totem.Domain.Dtos;

namespace Totem.Domain.Entities
{
    public class Positions : EntityBase<long>
    {
        private Positions() { }

        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

        public ICollection<Users> Users { get; set; }

        public static Positions Of(PositionDto positionDto)
        => new Positions
        {
            Active = positionDto.Active,
            Description = positionDto.Description,
            CreatedAt = DateTime.UtcNow
        };

        public static Positions Update(PositionDto positionDto)
        => new Positions
        {
            Active = positionDto.Active,
            Description = positionDto.Description,
            UpdatedAt = DateTime.UtcNow
        };
    }
}
