using Totem.Domain.Abstractions.Base;
using Totem.Domain.Dtos;
using Totem.Domain.Enums;

namespace Totem.Domain.Entities
{
    public class Operations : EntityBase<long>
    {
        private Operations() { }

        public Guid Id { get; set; }

        public ICollection<Causes> Causes { get; set; }
        public Guid? CauseId { get; set; }
        public Taxpayers Taxpayer { get; set; }
        public Guid? TaxpayerId { get; set; }
        public Branch Branch { get; set; }
        public Guid? BranchId { get; set; }

        public int? QuantityCauses { get; set; }
        public double? ValueTotalCauses { get; set; }
        public double? ValueTotalOperation { get; set; }
        public TypePayment PaymentMethod { get; set; }
        public DateTime DateOperation { get; set; }
        public TimeSpan HourOperation { get; set; }
        public string? Comments { get; set; }

        public static Operations Of(OperationDto operationDto)
        => new Operations
        {
            BranchId = operationDto.BranchId,
            CauseId = operationDto.CauseId,
            Comments = operationDto.Comments,
            CreatedAt = DateTime.UtcNow,
            DateOperation = DateTime.UtcNow.Date,
            PaymentMethod = operationDto.PaymentMethod,
            QuantityCauses = operationDto.QuantityCauses,
            HourOperation = SetOperationHour(),
            TaxpayerId = operationDto.TaxpayerId,
            ValueTotalCauses = operationDto.ValueTotalCauses,
            ValueTotalOperation = operationDto.ValueTotalOperation,

        };

        public static Operations Update(OperationDto operationDto)
        => new Operations
        {
            BranchId = operationDto.BranchId,
            CauseId = operationDto.CauseId,
            Comments = operationDto.Comments,
            UpdatedAt = DateTime.UtcNow,
            DateOperation = DateTime.UtcNow.Date,
            PaymentMethod = operationDto.PaymentMethod,
            QuantityCauses = operationDto.QuantityCauses,
            HourOperation = SetOperationHour(),
            TaxpayerId = operationDto.TaxpayerId,
            ValueTotalCauses = operationDto.ValueTotalCauses,
            ValueTotalOperation = operationDto.ValueTotalOperation,

        };

        private static TimeSpan SetOperationHour()
        => new TimeSpan(
                DateTime.UtcNow.Hour,
                DateTime.UtcNow.Minute,
                DateTime.UtcNow.Second);

    }
}
