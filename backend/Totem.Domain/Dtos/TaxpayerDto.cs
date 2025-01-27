namespace Totem.Domain.Dtos
{
    public class TaxpayerDto
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string? Telephone { get; set; }
        public bool Worker { get; set; }
        public long? Registration { get; set; }
        public bool Active { get; set; }
        public string? Address { get; set; }
        public Guid? PositionId { get; set; }
        public Guid? BranchId { get; set; }
    }
}
