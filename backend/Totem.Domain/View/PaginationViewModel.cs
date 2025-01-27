namespace Totem.Domain.View
{
    public class PaginationViewModel<T>
    {
        public IEnumerable<T> Data { get; set; }
        public int TotalItems { get; set; }
    }
}
