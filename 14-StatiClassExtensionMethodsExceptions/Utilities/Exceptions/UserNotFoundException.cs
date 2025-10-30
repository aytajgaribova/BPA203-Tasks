using System;
using _14_StatiClassExtensionMethodsExceptions.Exception;
using _14_StatiClassExtensionMethodsExceptions.Models;
namespace _14_StatiClassExtensionMethodsExceptions.Exception
{
    public class UserNotFoundException : System.Exception
    {
        private static object username;

        public UserNotFoundException()
            : base("Istifadeci tapilmadi") { }
        public UserNotFoundException(string message)
            : base($"User : {username} not found.") { }
    }


}

