using SceneIt.DAL.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SceneIt.DAL.Configurations
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            this.HasMany(e => e.UserMedia)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
