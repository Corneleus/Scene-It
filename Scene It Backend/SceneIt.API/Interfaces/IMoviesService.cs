using SceneIt.DAL.Entities;
using System.Collections.Generic;

namespace SceneIt.API.Interfaces
{
    public interface IMoviesService
    {
        List<Movies> GetAll();
        Movies Get(int id);
       
    }
}
