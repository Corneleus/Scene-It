using SceneIt.DAL.Entities;
using SceneIt.DAL.Infrastructure;
using SceneIt.DAL.Interfaces;

namespace SceneIt.DAL.Repositories
{
    public class UserMovieRepository : BaseRepository<UserMovie>, IUserMovieRepository
    {
        public UserMovieRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
}
