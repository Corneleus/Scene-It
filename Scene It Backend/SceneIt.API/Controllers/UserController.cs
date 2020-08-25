using SceneIt.API.Interfaces;
using SceneIt.API.Services;
using SceneIt.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SceneIt.API.Controllers
{
    [RoutePrefix("api/user")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserController : ApiController
    {
        private readonly IUserService userService;

        public UserController()
        {
            this.userService = new UserService();
        }

        [HttpGet]
        [Route("")]
        public List<User> GetAll()
        {
            try
            {
                return this.userService.GetAll();
            }
            catch (Exception)
            {

                return new List<User>();
            }
        }

        [HttpGet]
        [Route("(id:int)")]
        public User Get(int id)
        {
            try
            {
                return this.userService.Get(id);
            }
            catch (Exception)
            {
                return default(User);
            }

        }

        // POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}
    }
}

