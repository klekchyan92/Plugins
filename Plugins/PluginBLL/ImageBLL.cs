using Microsoft.EntityFrameworkCore;
using Plugins.PluginBLL.Interfaces;
using Plugins.PluginDAL;
using Plugins.PluginDAL.Entities;

namespace Plugins.PluginBLL
{
    public class ImageBLL : IImageBLL
    {
        readonly IUnitOfWork _imageService;

        public ImageBLL(IUnitOfWork imageService)
        {
            _imageService = imageService;
        }

        public async Task Create(Image model)
        {
            _imageService.Repository<Image>().Add(model);
            await _imageService.SaveAsync();
        }

        public async Task Delete(int id)
        {
            var image = await _imageService.Repository<Image>().DbSet.FirstOrDefaultAsync(u => u.Id == id);
            if (image is null)
                throw new Exception("Image Not Found");

            _imageService.Repository<Image>().Delete(image);
            await _imageService.SaveAsync();
        }

        public async Task<Image> Get(int id)
        {
            var image = await _imageService.Repository<Image>().DbSet.FirstOrDefaultAsync(u => u.Id == id);
            if (image is null)
                throw new Exception("Image not found");

            return image;
        }

        public async Task<List<Image>> GetAll()
        {
            return await _imageService.Repository<Image>().DbSet.ToListAsync();
        }

        public async Task Update(Image model)
        {
            var image = await _imageService.Repository<Image>().DbSet.FirstOrDefaultAsync(u => u.Id == model.Id);
            if (image is null)
                throw new Exception("Image not found");

            _imageService.Repository<Image>().Update(model);
            await _imageService.SaveAsync();
        }
    }
}
