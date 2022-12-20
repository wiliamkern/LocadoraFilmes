using LocadoraFilmes.Model;
using LocadoraFilmes.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraFilmes.Facade
{
    public interface IMovieFacade
    {
        void MovieOperations();
        Task<bool> InsertMovie(Movie movie);
        Movie GetMovie(int id);
        bool DeleteMovie(int id);
        bool UpdateMovie(Movie movie);
    }

    public class MovieFacade : IMovieFacade
    {
        private readonly IMovieRepo _movieRepo;
        public MovieFacade()
        {
            _movieRepo = new MovieRepo();
        }

        public async Task<bool> InsertMovie(Movie movie)
        {
            var result = await _movieRepo.InsertMovie(movie);

            return result;
        }

        public Movie GetMovie(int id)
        {

            return default;
        }

        public bool DeleteMovie(int id)
        {

            return default;
        }

        public bool UpdateMovie(Movie movie)
        {



            return default;
        }

        public void MovieOperations()
        {
            throw new NotImplementedException();
        }
    }
}
