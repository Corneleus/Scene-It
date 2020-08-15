using SceneIt.API.Interfaces;
using SceneIt.API.Services;
using SceneIt.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace SceneIt.API.Controllers
{
    [RoutePrefix("api/movies")]
    public class MoviesController : ApiController
    {
        private readonly IMoviesService moviesService;

        public MoviesController()
        {
            this.moviesService = new MoviesService();
        }
        
        [Route("")]
        [HttpGet]
        public List<Movies> GetAll()
        {
            try
            {
                return this.moviesService.GetAll();
            }
            catch (Exception)
            {
                return new List<Movies>();
                
            }           
        }

        [Route("/(id:int)")]
        [HttpGet]
        public Movies Get(int id)
        {
            try
            {
                return this.moviesService.Get(id);
            }
            catch (Exception)
            {
                return default(Movies);
            }
            
        }
                
        // POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}
    }
}