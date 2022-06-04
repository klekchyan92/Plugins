using Microsoft.EntityFrameworkCore;
using Plugins.PluginBLL.Interfaces;
using Plugins.PluginDAL;
using Plugins.PluginDAL.Entities;

namespace Plugins.PluginBLL.Services
{
    public class ImageService : Repository<Image>, IImageService
    {
        public ImageService(PluginContext context) : base(context)
        {
        }

        public Image Add(Image user)
        {
            _pluginContext.Images.Add(user);
            _pluginContext.SaveChanges();
            return user;
        }

        public void Delete(Image image)
        {
            var existingUser = _pluginContext.Images.FirstOrDefault(u => u.Id == image.Id);

            if (existingUser is null)
                throw new Exception("User Not Found");

            _pluginContext.Images.Remove(existingUser);
            _pluginContext.SaveChanges();
        }

        public void Update(Image image)
        {

            var existingImage = _pluginContext.Images.FirstOrDefault(u => u.Id == image.Id);

            if (existingImage is null)
                throw new Exception("User Not Found");

            SetData(image, existingImage);

            _pluginContext.Images.Update(existingImage);
            _pluginContext.SaveChanges();
        }

        public async Task<Image> GetAsync(int id)
        {
            var existingImage = await _pluginContext.Images.FirstOrDefaultAsync(u => u.Id == id);

            if (existingImage is null)
                throw new Exception("Image Not Found");

            return existingImage;
        }

        public void SetData(Image user, Image existingImage)
        {
            existingImage.PictureName = user.PictureName;
            existingImage.Pixel = user.Pixel;
            existingImage.Size = user.Size;
        }
    }
}
