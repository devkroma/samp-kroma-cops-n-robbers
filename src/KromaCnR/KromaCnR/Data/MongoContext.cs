using KromaCnR.Config;
using KromaCnR.Data.Models;
using MongoDB.Driver;

namespace KromaCnR.Data
{
    class MongoContext
    {
        public static readonly MongoContext Instance = new MongoContext();

        public readonly IMongoDatabase Database;

        public MongoContext()
        {
            var connectionString = ConfigContext.config["ConnectionStrings:MongoConnection"];
            var settings = MongoClientSettings.FromUrl(new MongoUrl(connectionString));
            var client = new MongoClient(settings);
            var dbName = ConfigContext.config["Database"];
            Database = client.GetDatabase(dbName);
        }

        public IMongoCollection<User> Users => Database.GetCollection<User>(ConfigContext.config["Collections:UserCollection"]);
    }
}
