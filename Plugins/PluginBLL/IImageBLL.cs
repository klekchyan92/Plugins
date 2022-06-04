using Plugins.PluginBLL.Interfaces;
using Plugins.PluginDAL.Entities;

namespace Plugins.PluginBLL
{
    public interface IImageBLL
    {
        Task Create(Image model);
        Task Update(Image model);
        Task Delete(int id);
        Task<Image> Get(int id);
        Task<List<Image>> GetAll();
    }
}
