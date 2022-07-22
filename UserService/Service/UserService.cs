using System;
using UserService.Exceptions;
using UserService.Models;
using UserService.Repository;

namespace UserService.Service
{
    public class UserService : IUserService
    {
        //define a private variable to represent repository

        //Use constructor Injection to inject all required dependencies.

        public UserService(IUserRepository userRepository)
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
