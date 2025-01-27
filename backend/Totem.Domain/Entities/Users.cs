using Totem.Domain.Abstractions.Base;
using Totem.Domain.Dtos;
using Totem.Domain.Enums;

namespace Totem.Domain.Entities
{
    public class Users : EntityBase<long>
    {
        private Users() { }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string? Telephone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public TypeUserEnum TypeUser { get; set; }
        public bool Active { get; set; }

        public Branch? Branch { get; set; }
        public Guid? BranchId { get; set; }

        public Positions? Position {  get; set; }
        public Guid? PositionId { get; set; }

        public static Users Of(UserDto user)
            => new Users
            {
                Name = user.Name,
                Cpf = user.Cpf,
                Telephone = user.Telephone,
                Email = user.Email,
                Password = user.Password,
                TypeUser = user.TypeUser,
                Active = user.Active,
                CreatedAt = DateTime.UtcNow,
            };

        public void Update(UserDto user)
        {
            Name = user.Name;
            Cpf = user.Cpf;
            Telephone = user.Telephone;
            Email = user.Email;
            Password = user.Password;
            TypeUser = user.TypeUser;
            Active = user.Active;
            UpdatedAt = DateTime.UtcNow;
        }

        public Users SetCryptPassword(string cryptPassword)
        {
            Password = cryptPassword;
            return this;
        }
    }
}
