using SceneIt.DAL.Entities;
using SceneIt.DAL.Infrastructure;
using SceneIt.DAL.Interfaces;

namespace SceneIt.DAL.Repositories
{
    public class UserMoviesRepository : BaseRepository<UserMovies>, IUserMoviesRepository
    {
        public UserMoviesRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
}
