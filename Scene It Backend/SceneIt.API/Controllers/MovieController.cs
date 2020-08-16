using SceneIt.API.Interfaces;
using SceneIt.API.Services;
using SceneIt.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace SceneIt.API.Controllers
{
    [RoutePrefix("api/movies")]
    public class MovieController : ApiController
    {
        private readonly IMovieService movieService;

        public MovieController()
        {
            this.movieService = new MovieService();
        }
        
        [Route("")]
        [HttpGet]
        public List<Movie> GetAll()
        {
            try
            {
                return this.movieService.GetAll();
            }
            catch (Exception)
            {
                return new List<Movie>();
                
            }           
        }

        [Route("/(id:int)")]
        [HttpGet]
        public Movie Get(int id)
        {
            try
            {
                return this.movieService.Get(id);
            }
            catch (Exception)
            {
                return default(Movie);
            }
            
        }
                
        // POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}
    }
}