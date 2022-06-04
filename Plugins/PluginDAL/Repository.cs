using Microsoft.EntityFrameworkCore;
using Nest;
using System.Linq.Expressions;

namespace Plugins.PluginDAL
{
    public class Repository <TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        protected PluginContext _pluginContext;

        public Repository(PluginContext context) => _pluginContext = context;

        public IQueryable<TEntity> DbSet => _pluginContext.Set<TEntity>();
        public TEntity Add(TEntity entity) => _pluginContext.Set<TEntity>().Add(entity).Entity;
        public void Delete(TEntity entity) => _pluginContext.Remove(entity);
        public Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate) => DbSet.AsNoTracking().FirstOrDefaultAsync(predicate);

        public Task<TEntity> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            _pluginContext.Set<TEntity>().Attach(entity);
            _pluginContext.Set<TEntity>().Update(entity);
        }
    }
}
