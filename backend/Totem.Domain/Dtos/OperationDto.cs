using Totem.Domain.Enums;

namespace Totem.Domain.Dtos
{
    public class OperationDto
    {
        public Guid? CauseId { get; set; }
        public Guid? TaxpayerId { get; set; }
        public Guid? BranchId { get; set; }
        public int? QuantityCauses { get; set; }
        public double ValueTotalCauses { get; set; }
        public double ValueTotalOperation { get; set; }
        public TypePayment PaymentMethod { get; set; }
        public string? Comments { get; set; }
    }
}
