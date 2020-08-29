using SceneIt.API.Interfaces;
using SceneIt.API.Services;
using SceneIt.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

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

        [HttpGet]
        [Route("")]
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

        [HttpGet]
        [Route("(id:int)")]
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

        [HttpPost]
        [Route("add")]
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