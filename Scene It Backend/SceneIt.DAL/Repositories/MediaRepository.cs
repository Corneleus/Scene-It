using SceneIt.DAL.Entities;
using SceneIt.DAL.Infrastructure;
using SceneIt.DAL.Interfaces;
namespace SceneIt.DAL.Repositories
{
    public class MediaRepository : BaseRepository<Media>, IMediaRepository
    {
        public MediaRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {                
        }
    }
}
