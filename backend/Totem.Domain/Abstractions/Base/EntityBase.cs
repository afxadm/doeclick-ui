namespace Totem.Domain.Abstractions.Base
{
    public abstract class EntityBase<TKey> : ErrorBase
    {
        public TKey Id { get; protected set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public void SetId(TKey id)
        {
            Id = id;
        }
    }
}
