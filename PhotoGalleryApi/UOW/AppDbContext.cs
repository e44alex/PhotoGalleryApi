
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using PhotoGalleryApi.Models;

namespace PhotoGalleryApi.UOW
{
    public class AppDbContext : DbContext
    {
        private readonly MongoClient _mongo;
        private readonly IMongoDatabase _database;
        private const string ConnectionString = "";
        public AppDbContext()
        {
            var settings = MongoClientSettings.FromConnectionString(
                $"mongodb://guest:guest@cluster0-shard-00-00.y3dlm.mongodb.net:27017,cluster0-shard-00-01.y3dlm.mongodb.net:27017," 
                + $"cluster0-shard-00-02.y3dlm.mongodb.net:27017/myFirstDatabase?ssl=true&replicaSet=atlas-bmmwcq-shard-0&authSource=admin&retryWrites=true&w=majority");

            var connection = new MongoUrlBuilder(ConnectionString);
            _mongo = new MongoClient(ConnectionString);
            _database = _mongo.GetDatabase(connection.DatabaseName);

            this.Photos?.AddRange(_database.GetCollection<Photo>(null, null).AsQueryable().ToList());
        }

        public DbSet<Photo> Photos { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }

        public override int SaveChanges()
        {
            return 0;
        }

    }
}
