namespace Plugins.PluginDAL
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly PluginContext _context;
        readonly Dictionary<Type, object> _repositories = new();

        public UnitOfWork(PluginContext context)
        {
            _context = context;
        }

        public Task<int> SaveAsync() => _context.SaveChangesAsync();

        public IRepository<TEntity> Repository<TEntity>() where TEntity : class, IEntity
        {
            if (_repositories.Keys.Contains(typeof(TEntity)))
                return _repositories[typeof(TEntity)] as IRepository<TEntity>;

            IRepository<TEntity> repository = new Repository<TEntity>(_context);
            _repositories.Add(typeof(TEntity), repository);
            return repository;
        }
    }
}
