﻿using SceneIt.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SceneIt.API.Interfaces
{
    public interface IUserMediaService
    {
        List<UserMedia> GetAll();
        UserMedia Get(int id);
    }
}
