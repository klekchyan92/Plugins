namespace Plugins.PluginDAL.Entities
{
    public class Image : IEntity
    {
        public int Id { get; set; }
        public string PictureName { get; set; } = null!;
        public int Size { get; set; }
        public decimal Pixel { get; set; }
     
    }
}
