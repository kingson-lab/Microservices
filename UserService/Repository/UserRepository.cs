using System;
using System.Linq;
using MongoDB.Driver;
using UserService.Models;

namespace UserService.Repository
{
    public class UserRepository:IUserRepository
    {
        //define a private variable to represent UserContext
        public UserRepository(UserContext _context)
        {
        }
        //This method should be used to delete an existing user.
        public bool DeleteUser(string userId)
        {
            throw new NotImplementedException();
        }

        //This method should be used to delete an existing user
        public User GetUserById(string userId)
        {
            throw new NotImplementedException();
        }
        //This method is used to register a new user
        public User RegisterUser(User user)
        {
            throw new NotImplementedException();
        }
        //This methos is used to update an existing user
        public bool UpdateUser(string userId, User user)
        {
            throw new NotImplementedException();
        }
    }
}
