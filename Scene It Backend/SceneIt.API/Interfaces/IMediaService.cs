using SceneIt.DAL.Entities;
using System.Collections.Generic;

namespace SceneIt.API.Interfaces
{
    public interface IMediaService
    {
        List<Media> GetAll();
        Media Get(int id);
       
    }
}
