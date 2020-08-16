using SceneIt.DAL.Entities;
using System.Collections.Generic;

namespace SceneIt.API.Interfaces
{
    public interface IUserMovieService
    {
        List<UserMovie> GetAll();
        UserMovie Get(int id);
    }
}
