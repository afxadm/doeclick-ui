using Totem.Domain.Entities;
using Totem.Domain.Enums;

namespace Totem.Domain.Dtos
{
    public class UserResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public TypeUserEnum TypeUser { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? BranchId { get; set; }
        public long? CodeBranch { get; set; }
        public string? NameBranch { get; set; }
        public string? AddressBranch { get; set; }
        public string? TelephoneBranch { get; set; }
        public Guid? PositionId { get; set; }
        public string? DescriptionPosition { get; set; }
        public bool? ActivePosition { get; set; }
        public string Token { get; set; }

        public static UserResponseDto Of(Users users, string token)
            => new UserResponseDto
            {
                Id = users.Id,
                Name = users.Name,
                Email = users.Email,
                Cpf = users.Cpf,
                TypeUser = users.TypeUser,
                CreatedAt = users.CreatedAt,
                BranchId = users.Branch?.Id,
                CodeBranch = users.Branch?.CodeBranch,
                NameBranch = users.Branch?.NameBranch,
                AddressBranch = users.Branch?.Address,
                TelephoneBranch = users.Branch?.Telephone,
                ActivePosition = users.Position?.Active,
                DescriptionPosition = users.Position?.Description,
                PositionId = users.Position?.Id,
                Token = token
            };
    }
}
