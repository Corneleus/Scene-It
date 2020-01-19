using SceneIt.DAL.Entities;
using SceneIt.DAL.Infrastructure;
using SceneIt.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
