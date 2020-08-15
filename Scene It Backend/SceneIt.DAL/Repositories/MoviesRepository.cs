using SceneIt.DAL.Entities;
using SceneIt.DAL.Infrastructure;
using SceneIt.DAL.Interfaces;
namespace SceneIt.DAL.Repositories
{
    public class MoviesRepository : BaseRepository<Movies>, IMoviesRepository
    {
        public MoviesRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {                
        }
    }
}
