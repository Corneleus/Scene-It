using SceneIt.API.Interfaces;
using SceneIt.DAL.Entities;
using SceneIt.DAL.Infrastructure;
using SceneIt.DAL.Interfaces;
using SceneIt.DAL.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace SceneIt.API.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository movieRepository;

        public MovieService()
        {
            var dbFactory = new DatabaseFactory();
            this.movieRepository = new MovieRepository(dbFactory);
        }

        public MovieService(IMovieRepository moviesRepository)
        {
            this.movieRepository = moviesRepository;
        }

        public List<Movie> GetAll()
        {
            return this.movieRepository.GetAll().ToList();
        }

        public Movie Get(int id)
        {
            return this.movieRepository.Get(id);
        }

        public void Add(Movie movie)
        {
            if(!this.movieRepository.GetMany(x => x.ImdbId == movie.ImdbId).Any())
            {
                this.movieRepository.Add(movie);
            }
        }
    }
}