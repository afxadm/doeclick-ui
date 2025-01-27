using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Totem.Domain.Abstractions.Base;
using Totem.Domain.Interfaces;

namespace Totem.Infrastructure.Data
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey>, IAsyncRepository<TEntity, TKey> where TEntity : EntityBase<TKey>
    {
        protected readonly DbContext _context;

        protected readonly DbSet<TEntity> _set;

        public Repository(DbContext context)
        {
            _context = context;
            _set = _context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _set.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _set.AddRange(entities);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _set.AddRangeAsync(entities);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _set;
        }

        public TEntity GetById(TKey id)
        {
            return _set.Find(id);
        }

        public async Task<TEntity> GetByIdAsync(TKey id)
        {
            return await _set.FindAsync(id);
        }

        public void Remove(params TKey[] ids)
        {
            _set.RemoveRange(_set.Where((TEntity d) => ids.Contains(d.Id)));
        }

        public void Remove(TEntity entity)
        {
            _set.Remove(entity);
        }

        public void Remove(Expression<Func<TEntity, bool>> criteria)
        {
            _set.RemoveRange(_set.Where(criteria));
        }

        public Task RemoveAsync(TEntity entity)
        {
            _set.Remove(entity);
            return Task.CompletedTask;
        }

        public async Task RemoveAsync(params TKey[] ids)
        {
            foreach (TKey val in ids)
            {
                TEntity entity = await _set.FindAsync(val);
                _set.Remove(entity);
            }
        }

        public void Update(TEntity entity)
        {
            TEntity entity2 = _set.Find(entity.Id);
            _context.Entry(entity2).CurrentValues.SetValues(entity);
        }

        public async Task AddAsync(TEntity entity)
        {
            await _set.AddAsync(entity);
        }

        public async Task<IList<TEntity>> GetAllAsync()
        {
            return await _set.ToListAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            TEntity entity2 = await _set.FindAsync(entity.Id);
            _context.Entry(entity2).CurrentValues.SetValues(entity);
        }
    }
}
