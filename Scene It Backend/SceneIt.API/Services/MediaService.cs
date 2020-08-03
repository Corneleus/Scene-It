using SceneIt.API.Interfaces;
using SceneIt.DAL.Entities;
using SceneIt.DAL.Infrastructure;
using SceneIt.DAL.Interfaces;
using SceneIt.DAL.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace SceneIt.API.Services
{
    public class MediaService : IMediaService
    {
        private readonly IMediaRepository mediaRepository;

        public MediaService()
        {
            var dbFactory = new DatabaseFactory();
            this.mediaRepository = new MediaRepository(dbFactory);
        }

        public MediaService(IMediaRepository mediaRepository)
        {
            this.mediaRepository = mediaRepository;
        }

        public List<Media> GetAll()
        {
            return this.mediaRepository.GetAll().ToList();
        }

        public Media Get(int id)
        {
            return this.mediaRepository.Get(id);
        }
    }
}