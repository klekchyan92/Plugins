using Plugins.PluginBLL.Interfaces;
using Plugins.PluginBLL.Services;

namespace Plugins.PluginAPI.Extensions
{
    public static class ImageDependency
    {
        public static void AddImageDependancy(this IServiceCollection services)
        {
            services.AddScoped(typeof(IImageService), typeof(ImageService));
        }
    }
}
