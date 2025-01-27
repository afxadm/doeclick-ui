using Totem.Domain.Abstractions.Base;
using Totem.Domain.Dtos;

namespace Totem.Domain.Entities
{
    public class Branch : EntityBase<long>
    {
        public Guid Id { get; set; }
        public long CodeBranch { get; set; }
        public string NameBranch { get; set; }
        public string? Address { get; set; }
        public string? Telephone { get; set; }
        public bool Active { get; set; }

        public ICollection<Users> Users { get; set; }
        public ICollection<Taxpayers> Taxpayers { get; set; }
        public Operations Operation { get; set; }

        public static Branch Of(BranchDto branch)
        => new Branch
        {
            Active = branch.Active,
            Address = branch.Address,
            Telephone = branch.Telephone,
            NameBranch = branch.NameBranch,
            CodeBranch = branch.CodeBranch,
            CreatedAt = DateTime.UtcNow
        };

        public static Branch Updated(BranchDto branch)
        => new Branch
        {
            Active = branch.Active,
            Address = branch.Address,
            Telephone = branch.Telephone,
            NameBranch = branch.NameBranch,
            CodeBranch = branch.CodeBranch,
            UpdatedAt = DateTime.UtcNow
        };
    }
}
