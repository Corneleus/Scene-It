using SceneIt.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SceneIt.API.Interfaces
{
    public interface IUserService
    {
        List<User> GetAll();
        User Get(int id);
    }
}
