using System.Linq.Expressions;

namespace Plugins.PluginDAL
{
    public interface IRepository<TEntity> where TEntity : class, IEntity
    {
        public IQueryable<TEntity> DbSet { get; }
        TEntity Add(TEntity entity);
        Task<TEntity> GetAsync(int id);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
