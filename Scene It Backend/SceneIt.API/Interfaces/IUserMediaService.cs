using SceneIt.DAL.Entities;
using System.Collections.Generic;

namespace SceneIt.API.Interfaces
{
    public interface IUserMediaService
    {
        List<UserMedia> GetAll();
        UserMedia Get(int id);
    }
}
