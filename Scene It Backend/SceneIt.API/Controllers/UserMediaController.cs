using SceneIt.API.Interfaces;
using SceneIt.API.Services;
using SceneIt.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Web.Http;
namespace SceneIt.API.Controllers
{
    [RoutePrefix("api/usermedia")]
    public class UserMediaController : ApiController
    {
        private readonly IUserMediaService userMediaService;

        public UserMediaController()
        {
            this.userMediaService = new UserMediaService();
        }

        [Route("")]
        [HttpGet]
        public List<UserMedia> GetAll()
        {
            try
            {
                return this.userMediaService.GetAll();
            }
            catch (Exception)
            {

                return new List<UserMedia>();
            }
        }

        [Route("/(id:int)")]
        [HttpGet]
        public UserMedia Get(int id)
        {
            try
            {
                return this.userMediaService.Get(id);
            }
            catch (Exception)
            {
                return default(UserMedia);
            }

        }
    }
}
