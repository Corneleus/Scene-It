using SceneIt.API.Interfaces;
using SceneIt.API.Services;
using SceneIt.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Web.Http;
namespace SceneIt.API.Controllers
{
    [RoutePrefix("api/usermovies")]
    public class UserMovieController : ApiController
    {
        private readonly IUserMovieService userMovieService;

        public UserMovieController()
        {
            this.userMovieService = new UserMovieService();
        }

        [Route("")]
        [HttpGet]
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

        [Route("/(id:int)")]
        [HttpGet]
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
