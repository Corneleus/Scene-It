using SceneIt.API.Interfaces;
using SceneIt.DAL.Entities;
using SceneIt.DAL.Infrastructure;
using SceneIt.DAL.Interfaces;
using SceneIt.DAL.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace SceneIt.API.Services
{
    public class UserMediaService : IUserMediaService
    {
        private readonly IUserMediaRepository userMediaRepository;

        public UserMediaService()
        {
            var dbFactory = new DatabaseFactory();
            this.userMediaRepository = new UserMediaRepository(dbFactory);
        }
       
        public UserMediaService(IUserMediaRepository userMediaRepository)
        {
            this.userMediaRepository = userMediaRepository;
        }

        public List<UserMedia> GetAll()
        {
            return this.userMediaRepository.GetAll().ToList();
        }

        public UserMedia Get(int id)
        {
            return this.userMediaRepository.Get(id);
        }      
    }
}