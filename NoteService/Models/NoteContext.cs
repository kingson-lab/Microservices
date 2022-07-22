using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace NoteService.Models
{
    public class NoteContext
    {
        //declare variables to connect to MongoDB database

        public NoteContext(IConfiguration configuration)
        {
            //Initialize MongoClient and Database using connection string and database name from configuration
        }

        //Define a MongoCollection to represent the Notes collection of MongoDB based on NoteUser type
    }
}
