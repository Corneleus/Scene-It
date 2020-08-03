using SceneIt.DAL.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SceneIt.DAL.Configurations
{
    public class MediaConfiguration : EntityTypeConfiguration<Media>
    {
        public MediaConfiguration()
        {
            this.HasMany(e => e.UserMedia)
                .WithRequired(e => e.Media)
                .WillCascadeOnDelete(false);
        }
    }
}
