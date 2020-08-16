using SceneIt.DAL.Entities;
using System.Collections.Generic;

namespace SceneIt.API.Interfaces
{
    public interface IUserService
    {
        List<User> GetAll();
        User Get(int id);
    }
}
