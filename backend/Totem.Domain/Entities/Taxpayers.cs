using Totem.Domain.Abstractions.Base;
using Totem.Domain.Dtos;

namespace Totem.Domain.Entities
{
    public class Taxpayers : EntityBase<long>
    {
        private Taxpayers() { }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string? Telephone { get; set; }
        public bool Worker { get; set; }
        public long? Registration { get; set; }
        public bool Active { get; set; }
        public string? Address { get; set; }

        public Positions Position { get; set; }
        public Guid? PositionId { get; set; }
        public Branch Branch { get; set; }
        public Guid? BranchId { get; set; }

        public Operations Operation { get; set; }

        public static Taxpayers Of(TaxpayerDto taxpayerDto)
        => new Taxpayers
        {
            Name = taxpayerDto.Name,
            Active = taxpayerDto.Active,
            Cpf = taxpayerDto.Cpf,
            Telephone = taxpayerDto.Telephone,
            Worker = taxpayerDto.Worker,
            Registration = taxpayerDto.Registration,
            Address = taxpayerDto.Address,
            CreatedAt = DateTime.UtcNow,
            PositionId = taxpayerDto.PositionId,
            BranchId = taxpayerDto.BranchId
        };

        public static Taxpayers Update(TaxpayerDto taxpayerDto)
        => new Taxpayers
        {
            Name = taxpayerDto.Name,
            Active = taxpayerDto.Active,
            Cpf = taxpayerDto.Cpf,
            Telephone = taxpayerDto.Telephone,
            Worker = taxpayerDto.Worker,
            Registration = taxpayerDto.Registration,
            Address = taxpayerDto.Address,
            UpdatedAt = DateTime.UtcNow,
            PositionId = taxpayerDto.PositionId,
            BranchId = taxpayerDto.BranchId
        };
    }
}
