using SceneIt.API.Interfaces;
using SceneIt.DAL.Entities;
using SceneIt.DAL.Infrastructure;
using SceneIt.DAL.Interfaces;
using SceneIt.DAL.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace SceneIt.API.Services
{
    public class UserMoviesService : IUserMoviesService
    {
        private readonly IUserMoviesRepository userMoviesRepository;

        public UserMoviesService()
        {
            var dbFactory = new DatabaseFactory();
            this.userMoviesRepository = new UserMoviesRepository(dbFactory);
        }
       
        public UserMoviesService(IUserMoviesRepository userMoviesRepository)
        {
            this.userMoviesRepository = userMoviesRepository;
        }

        public List<UserMovies> GetAll()
        {
            return this.userMoviesRepository.GetAll().ToList();
        }

        public UserMovies Get(int id)
        {
            return this.userMoviesRepository.Get(id);
        }      
    }
}