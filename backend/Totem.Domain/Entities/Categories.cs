using Totem.Domain.Abstractions.Base;
using Totem.Domain.Dtos;

namespace Totem.Domain.Entities
{
    public class Categories : EntityBase<long>
    {
        private Categories() { }

        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

        public Causes Causes { get; set; }

        public static Categories Of(CategoryDto categoryDto)
        => new Categories
        {
            Description = categoryDto.Description,
            Active = categoryDto.Active,
            CreatedAt = DateTime.UtcNow
        };

        public static Categories Update(CategoryDto categoryDto)
        => new Categories
        {
            Description = categoryDto.Description,
            Active = categoryDto.Active,
            UpdatedAt = DateTime.UtcNow
        };
    }
}
