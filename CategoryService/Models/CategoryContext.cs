using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace CategoryService.Models
{
    public class CategoryContext
    {
        //declare variable to connect to MongoDB database

        public CategoryContext(IConfiguration configuration)
        {
            //Initialize MongoClient and Database using connection string and database name from configuration
        }

        //Define a MongoCollection to represent the Categories collection of MongoDB
    }
}
