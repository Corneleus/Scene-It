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
        public IHttpActionResult GetAll()
        {
            try
            {
                return this.Ok(this.movieService.GetAll());
            }
            catch (Exception e)
            {
                return this.InternalServerError(e);                
            }           
        }

        [Route("/(id:int)")]
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            try
            {
                return this.Ok(this.movieService.Get(id));
            }
            catch (Exception e)
            {
                return this.InternalServerError(e);
            }
            
        }

        [Route("/add")]
        [HttpPost]
        public IHttpActionResult Add(Movie movie)
        {
            try
            {
                this.movieService.Add(movie);
                return this.Ok("Movie was Added");
            }
            catch (Exception e)
            {
                return this.InternalServerError(e);
            }
        }
       
    }
}