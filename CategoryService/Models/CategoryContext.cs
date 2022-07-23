using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace CategoryService.Models
{
    public class CategoryContext
    {
        //Define a MongoCollection to represent the Categories collection of MongoDB
        public readonly IMongoCollection<Category> Category;

        public CategoryContext(IConfiguration configuration)
        {
            //Initialize MongoClient and Database using connection string and database name from configuration
            var mongoClient = new MongoClient(configuration["DatabaseSettings:ConnectionString"]);
            var Database = mongoClient.GetDatabase(configuration["DatabaseSettings:DatabaseName"]);
            Category = Database.GetCollection<Category>("Category");
        }

        


    }
}
