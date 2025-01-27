using Totem.Domain.Enums;

namespace Totem.Domain.Dtos
{
    public class CauseDto
    {
        public string Description { get; set; }
        public Guid? CategoryId { get; set; }
        public CauseType? CauseType { get; set; }
        public bool Active { get; set; }
        public float? Value { get; set; }
        public bool Goal { get; set; }
        public float ValueGoal { get; set; }
        public string? Observations { get; set; }
        public string? TokenPagBank { get; set; }
    }
}
