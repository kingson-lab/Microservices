using AuthenticationService.Exceptions;
using AuthenticationService.Models;
using AuthenticationService.Repository;
using System;

namespace AuthenticationService.Service
{
    public class AuthService : IAuthService
    {
        //define a private variable to represent repository

        //Use constructor Injection to inject all required dependencies.

        public AuthService(IAuthRepository authRepository)
        {

        }

        //This methos should be used to register a new user
        public bool RegisterUser(User user)
        {
            throw new NotImplementedException();
        }

        //This method should be used to login for existing user
        public bool LoginUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
