namespace Totem.Domain
{
    public class ResponseBase<T>
    {
        public bool IsSuccess { get; set; }

        public object Data { get; set; }
    }
}
