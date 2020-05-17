using SceneIt.API.Interfaces;
using SceneIt.API.Services;
using SceneIt.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SceneIt.API.Controllers
{
    [RoutePrefix("api/media")]
    public class MediaController : ApiController
    {
        private readonly IMediaService mediaService;

        public MediaController()
        {
            this.mediaService = new MediaService();
        }
        
        [Route("")]
        [HttpGet]
        public List<Media> GetAll()
        {
            try
            {
                return this.mediaService.GetAll();
            }
            catch (Exception)
            {
                return new List<Media>();
                
            }           
        }

        [Route("/(id:int)")]
        [HttpGet]
        public Media Get(int id)
        {
            try
            {
                return this.mediaService.Get(id);
            }
            catch (Exception)
            {
                return default(Media);
            }
            
        }
                
        // POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}
    }
}