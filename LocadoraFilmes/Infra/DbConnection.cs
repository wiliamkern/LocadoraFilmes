
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraFilmes.Infra
{
    public interface IDbConnection
    {
        IMongoDatabase MongoDbConnection();
    }

    public class DbConnection : IDbConnection
    {
        IConnectionsInfos _connectionsInfos; 

        public DbConnection()
        {
            _connectionsInfos = new ConnectionsInfos();
        }

        public IMongoDatabase MongoDbConnection()
        {
            MongoClient client = new MongoClient(_connectionsInfos.GetMongoConnection());
            IMongoDatabase database = client.GetDatabase(_connectionsInfos.GetMongoDatabase());

            return database;
        }
    }
}
