namespace Totem.Domain
{
    public class PaginationParams
    {
        public int? PageIndex { get; set; } = 1;
        public int? ItemsByPage { get; set; } = 10;
    }
}
