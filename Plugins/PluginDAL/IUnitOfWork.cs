namespace Plugins.PluginDAL
{
    public interface IUnitOfWork
    {
        Task<int> SaveAsync();
        IRepository<TEntity> Repository<TEntity>() where TEntity : class, IEntity;
    }
}
