using System;
using _14_StatiClassExtensionMethodsExceptions.Exception;
using _14_StatiClassExtensionMethodsExceptions.Models;
namespace _14_StatiClassExtensionMethodsExceptions.Exception
{
    public class InvalidPasswordException : System.Exception
    {
        public InvalidPasswordException()
            : base("Pasword bos ve 6 simvoldan az ola bilmez") { }
        public InvalidPasswordException(string message)
            : base(message) { }


    }
}
