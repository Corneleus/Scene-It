using SceneIt.DAL.Entities;
using SceneIt.DAL.Infrastructure;
using SceneIt.DAL.Interfaces;

namespace SceneIt.DAL.Repositories
{
    public class UserMediaRepository : BaseRepository<UserMedia>, IUserMediaRepository
    {
        public UserMediaRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
}
