using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraFilmes.Infra
{
    public interface IConnectionsInfos
    {
        string GetMongoConnection();
        string GetMongoDatabase();
        string GetMoviesCollection();
    }

    public class ConnectionsInfos : IConnectionsInfos
    {
        private readonly string MONGO_CLOUD_CONNECTION = "mongodb+srv://wiliamkern:mongodatabase994455@cluster0.ve2rh79.mongodb.net/?retryWrites=true&w=majority";
        private readonly string MONGO_DATABASE = "LocadoraDB";
        private readonly string MONGO_COLLECTION_MOVIES = "Movies";

        public string GetMongoConnection()
            => MONGO_CLOUD_CONNECTION;

        public string GetMongoDatabase()
            => MONGO_DATABASE;

        public string GetMoviesCollection()
            => MONGO_COLLECTION_MOVIES;
    }
}
