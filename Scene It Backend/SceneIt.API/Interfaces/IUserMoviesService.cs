using SceneIt.DAL.Entities;
using System.Collections.Generic;

namespace SceneIt.API.Interfaces
{
    public interface IUserMoviesService
    {
        List<UserMovies> GetAll();
        UserMovies Get(int id);
    }
}
