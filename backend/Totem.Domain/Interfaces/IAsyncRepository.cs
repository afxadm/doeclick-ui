using Totem.Domain.Abstractions.Base;

namespace Totem.Domain.Interfaces
{
    public interface IAsyncRepository<TEntity, TKey> where TEntity : EntityBase<TKey>
    {
        Task AddAsync(TEntity entity);

        Task AddRangeAsync(IEnumerable<TEntity> entities);

        Task<TEntity> GetByIdAsync(TKey id);

        Task<IList<TEntity>> GetAllAsync();

        Task UpdateAsync(TEntity entity);

        Task RemoveAsync(params TKey[] ids);

        Task RemoveAsync(TEntity entity);
    }
}
