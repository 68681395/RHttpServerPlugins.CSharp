using MongoDB.Driver;

namespace RHttpServer.Plugins.External
{
    public class SimpleMongoDBConnection : RPlugin
    {
        private readonly MongoClient _client;

        public SimpleMongoDBConnection(string url, int port = 80)
        {
            _client = new MongoClient($"{url}:{port}");
        }

        public IMongoDatabase GetDatabase(string db) => _client.GetDatabase(db);
    }
}
