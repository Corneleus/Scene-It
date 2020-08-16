using SceneIt.DAL.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SceneIt.DAL.Configurations
{
    public class MovieConfiguration : EntityTypeConfiguration<Movie>
    {
        public MovieConfiguration()
        {
            this.HasMany(e => e.UserMovies)
                .WithRequired(e => e.Movie)
                .WillCascadeOnDelete(false);
        }
    }
}
