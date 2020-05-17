using SceneIt.API.Interfaces;
using SceneIt.DAL.Entities;
using SceneIt.DAL.Infrastructure;
using SceneIt.DAL.Interfaces;
using SceneIt.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SceneIt.API.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService()
        {
            var dbfactory = new DatabaseFactory();
            this.userRepository = new UserRepository(dbfactory);
        }

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public List<User> GetAll()
        {
            return this.userRepository.GetAll().ToList();
        }

        public User Get(int id)
        {
            return this.userRepository.Get(id);
        }      
    }
}