using InternetoTechnologijosND.Objects;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace InternetoTechnologijosND.Database
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<Todo> _todos;

        public MongoDbContext(IConfiguration configuration)
        {
            var connectionString = configuration["MongoDB:ConnectionString"];
            var databaseName = configuration["MongoDB:DatabaseName"];
            var collectionName = configuration["MongoDB:CollectionName"];

            var mongoClient = new MongoClient(connectionString);
            _database = mongoClient.GetDatabase(databaseName);
            _todos = _database.GetCollection<Todo>(collectionName);
        }

        public IMongoCollection<Todo> Todos => _todos;
    }
}