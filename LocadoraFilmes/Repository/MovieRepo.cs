using LocadoraFilmes.Infra;
using LocadoraFilmes.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraFilmes.Repository
{
    public interface IMovieRepo
    {
        Task<bool> InsertMovie(Movie movie);
        Task<bool> UpdateMovie(Movie movie);
        Task<bool> DeleteMovie(int movieId);
        Task<Movie> GetMovieById();
        Task<List<Movie>> GetMovieList();
    }

    public class MovieRepo : IMovieRepo
    {
        public IDbConnection _database;
        public IConnectionsInfos _infos;

        public MovieRepo()
        {
            _database = new DbConnection();
            _infos = new ConnectionsInfos();
        }

        public async Task<bool> InsertMovie(Movie movie)
        {
            try
            {
                movie.MovieID = await GetNextID();

                var db = _database.MongoDbConnection();
                var collection = db.GetCollection<Movie>(_infos.GetMoviesCollection());

                await collection.InsertOneAsync(movie);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao Inserir dados no banco, Erro: " + ex.Message);

                return false;
            }
        }

        public Task<bool> DeleteMovie(int movieId)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> GetMovieById()
        {
            throw new NotImplementedException();
        }

        public Task<List<Movie>> GetMovieList()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public async Task<int> GetNextID()
        {
            var db = _database.MongoDbConnection();
            var collection = db.GetCollection<Movie>(_infos.GetMoviesCollection());

            var result = await collection.EstimatedDocumentCountAsync();

            return (int)result + 1;
        }
    }
}
