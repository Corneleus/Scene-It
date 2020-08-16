using SceneIt.API.Interfaces;
using SceneIt.DAL.Entities;
using SceneIt.DAL.Infrastructure;
using SceneIt.DAL.Interfaces;
using SceneIt.DAL.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace SceneIt.API.Services
{
    public class UserMovieService : IUserMovieService
    {
        private readonly IUserMovieRepository userMovieRepository;

        public UserMovieService()
        {
            var dbFactory = new DatabaseFactory();
            this.userMovieRepository = new UserMovieRepository(dbFactory);
        }
       
        public UserMovieService(IUserMovieRepository userMoviesRepository)
        {
            this.userMovieRepository = userMoviesRepository;
        }

        public List<UserMovie> GetAll()
        {
            return this.userMovieRepository.GetAll().ToList();
        }

        public UserMovie Get(int id)
        {
            return this.userMovieRepository.Get(id);
        }      
    }
}