using Microsoft.EntityFrameworkCore;
using Plugins.PluginDAL.Entities;
using Plugins.PluginDAL.EntityConfigurations;

namespace Plugins.PluginDAL
{
    public class PluginContext : DbContext
    {
        public DbSet<Image> Images { get; set; }

        public PluginContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public PluginContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ImageConfiguration());
        }
    }
}
