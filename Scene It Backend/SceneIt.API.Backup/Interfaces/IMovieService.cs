using SceneIt.DAL.Entities;
using System.Collections.Generic;

namespace SceneIt.API.Interfaces
{
    public interface IMovieService
    {
        List<Movie> GetAll();
        Movie Get(int id);

        void Add(Movie movie);
       
    }
}
