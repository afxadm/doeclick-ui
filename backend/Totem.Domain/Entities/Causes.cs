using Totem.Domain.Abstractions.Base;
using Totem.Domain.Dtos;
using Totem.Domain.Enums;

namespace Totem.Domain.Entities
{
    public class Causes : EntityBase<long>
    {
        private Causes() { }

        public Guid Id { get; set; }
        public string Description { get; set; }
        public Categories Category { get; set; }
        public Guid? CategoryId { get; set; }
        public CauseType? CauseType { get; set; }
        public bool Active { get; set; }
        public double? Value { get; set; }
        public bool Goal { get; set; }
        public double? ValueGoal { get; set; }
        public string? Observations { get; set; }
        public string TokenPagBank { get; set; }

        //public Operations Operation { get; set; }

        public static Causes Of(CauseDto causeDto)
        => new Causes
        {
            Id = Guid.NewGuid(),
            Active = causeDto.Active,
            Value = causeDto.Value,
            Goal = causeDto.Goal,
            CauseType = causeDto.CauseType,
            CreatedAt = DateTime.UtcNow,
            TokenPagBank = causeDto.TokenPagBank,
            ValueGoal = causeDto.ValueGoal,
            CategoryId = causeDto.CategoryId,
            Description = causeDto.Description,
            Observations = causeDto.Observations
        };

        public static Causes Update(CauseDto causeDto)
        => new Causes
        {
            Active = causeDto.Active,
            Value = causeDto.Value,
            Goal = causeDto.Goal,
            CauseType = causeDto.CauseType,
            UpdatedAt = DateTime.UtcNow,
            TokenPagBank = causeDto.TokenPagBank,
            ValueGoal = causeDto.ValueGoal,
            CategoryId = causeDto.CategoryId,
            Description = causeDto.Description,
            Observations = causeDto.Observations
        };
    }
}
