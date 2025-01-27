using System.Linq.Expressions;
using Totem.Domain.Abstractions.Base;

namespace Totem.Infrastructure.Data
{
    public interface IRepository<TEntity, TKey> where TEntity : EntityBase<TKey>
    {
        void Add(TEntity entity);

        void AddRange(IEnumerable<TEntity> entities);

        TEntity GetById(TKey id);

        IQueryable<TEntity> GetAll();

        void Update(TEntity entity);

        void Remove(params TKey[] ids);

        void Remove(Expression<Func<TEntity, bool>> criteria);

        void Remove(TEntity entity);
    }
}
