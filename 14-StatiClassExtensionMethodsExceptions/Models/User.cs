using System;
using _14_StatiClassExtensionMethodsExceptions.Exception;
using _14_StatiClassExtensionMethodsExceptions.Models;
namespace _14_StatiClassExtensionMethodsExceptions.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsLocked { get; set; }
        public int FailedAttempts { get; set; }


        public User(string username, string password)
        {
            Username = username;
            Password = password;
            IsLocked = false;
            FailedAttempts = 0;
        }

    }

}


