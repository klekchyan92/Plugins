using Microsoft.AspNetCore.Mvc;
using Plugins.PluginBLL.Interfaces;
using Plugins.PluginDAL.Entities;

namespace Plugins.PluginAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImageController : ControllerBase
    {
        private readonly IImageService _imageService;

        public ImageController(IImageService userService)
        {
            _imageService = userService;
        }

        [HttpGet("{id}")]
        public Task<Image> Get(int id) => _imageService.GetAsync(id);

        [HttpPut]
        public void Update(Image model) => _imageService.Update(model);

        [HttpDelete]
        public void Delete(Image model) => _imageService.Delete(model);

        [HttpPost]
        public Image Add(Image model) => _imageService.Add(model);
    }
}
