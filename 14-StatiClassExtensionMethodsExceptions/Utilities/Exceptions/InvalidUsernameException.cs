using System;
using _14_StatiClassExtensionMethodsExceptions.Exception;
using _14_StatiClassExtensionMethodsExceptions.Models;
namespace _14_StatiClassExtensionMethodsExceptions.Exception
{
    public class InvalidUsernameException : System.Exception
    {
        public InvalidUsernameException()
           : base("Username bos ve 3 simvoldan az ola bilmez.") { }

        public InvalidUsernameException(string message)
            : base(message) { }
    }
}