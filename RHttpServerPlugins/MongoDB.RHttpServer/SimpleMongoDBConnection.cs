using MongoDB.Driver;

namespace RHttpServer.Plugins.External
{
    /// <summary>
    /// 
    /// </summary>
    public class SimpleMongoDBConnection : RPlugin
    {
        private readonly MongoClient _client;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="port"></param>
        public SimpleMongoDBConnection(string url, int port = 27017)
        {
            _client = new MongoClient($"{url}:{port}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public IMongoDatabase GetDatabase(string db) => _client.GetDatabase(db);
    }
}
