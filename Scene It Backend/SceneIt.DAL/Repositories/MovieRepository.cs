using SceneIt.DAL.Entities;
using SceneIt.DAL.Infrastructure;
using SceneIt.DAL.Interfaces;
namespace SceneIt.DAL.Repositories
{
    public class MovieRepository : BaseRepository<Movie>, IMovieRepository
    {
        public MovieRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {                
        }
    }
}
