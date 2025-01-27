using Totem.Domain.Enums;

namespace Totem.Domain.Dtos
{
    public class UserDto
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public TypeUserEnum TypeUser { get; set; }
        public bool Active { get; set; }
        public Guid? BranchId { get; set; }
        public Guid? PositionId { get; set; }
    }
}
