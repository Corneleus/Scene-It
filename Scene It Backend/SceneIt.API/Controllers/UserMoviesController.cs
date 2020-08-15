using SceneIt.API.Interfaces;
using SceneIt.API.Services;
using SceneIt.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Web.Http;
namespace SceneIt.API.Controllers
{
    [RoutePrefix("api/usermovies")]
    public class UserMoviesController : ApiController
    {
        private readonly IUserMoviesService userMoviesService;

        public UserMoviesController()
        {
            this.userMoviesService = new UserMoviesService();
        }

        [Route("")]
        [HttpGet]
        public List<UserMovies> GetAll()
        {
            try
            {
                return this.userMoviesService.GetAll();
            }
            catch (Exception)
            {

                return new List<UserMovies>();
            }
        }

        [Route("/(id:int)")]
        [HttpGet]
        public UserMovies Get(int id)
        {
            try
            {
                return this.userMoviesService.Get(id);
            }
            catch (Exception)
            {
                return default(UserMovies);
            }

        }
    }
}
