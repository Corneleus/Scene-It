using SceneIt.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
