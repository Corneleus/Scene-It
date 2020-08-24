using SceneIt.API.Interfaces;
using SceneIt.API.Services;
using SceneIt.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SceneIt.API.Controllers
{
    [RoutePrefix("api/usermovies")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserMovieController : ApiController
    {
        private readonly IUserMovieService userMovieService;

        public UserMovieController()
        {
            this.userMovieService = new UserMovieService();
        }

        [HttpGet]
        [Route("")]
        public List<UserMovie> GetAll()
        {
            try
            {
                return this.userMovieService.GetAll();
            }
            catch (Exception)
            {

                return new List<UserMovie>();
            }
        }

        [HttpGet]
        [Route("(id:int)")]
        public UserMovie Get(int id)
        {
            try
            {
                return this.userMovieService.Get(id);
            }
            catch (Exception)
            {
                return default(UserMovie);
            }

        }
    }
}
