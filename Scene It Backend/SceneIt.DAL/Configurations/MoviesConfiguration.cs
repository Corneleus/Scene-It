using SceneIt.DAL.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SceneIt.DAL.Configurations
{
    public class MoviesConfiguration : EntityTypeConfiguration<Movies>
    {
        public MoviesConfiguration()
        {
            this.HasMany(e => e.UserMovies)
                .WithRequired(e => e.Movies)
                .WillCascadeOnDelete(false);
        }
    }
}
