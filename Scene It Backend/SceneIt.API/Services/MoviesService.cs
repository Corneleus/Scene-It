using SceneIt.API.Interfaces;
using SceneIt.DAL.Entities;
using SceneIt.DAL.Infrastructure;
using SceneIt.DAL.Interfaces;
using SceneIt.DAL.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace SceneIt.API.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly IMoviesRepository moviesRepository;

        public MoviesService()
        {
            var dbFactory = new DatabaseFactory();
            this.moviesRepository = new MoviesRepository(dbFactory);
        }

        public MoviesService(IMoviesRepository moviesRepository)
        {
            this.moviesRepository = moviesRepository;
        }

        public List<Movies> GetAll()
        {
            return this.moviesRepository.GetAll().ToList();
        }

        public Movies Get(int id)
        {
            return this.moviesRepository.Get(id);
        }
    }
}