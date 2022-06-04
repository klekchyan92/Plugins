using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Plugins.PluginDAL.Entities;

namespace Plugins.PluginDAL.EntityConfigurations
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            //builder.Property(x => x.PictureName).HasColumnType("VARCHAR(100)");
            //builder.Property(x => x.Pixel).HasColumnType("VARCHAR(100)");
            //builder.Property(x => x.Size).HasColumnType("VARCHAR(100)");
            //builder.Property(x => x.OrganizationName).HasColumnType("VARCHAR(100)");

        }
    }
}
