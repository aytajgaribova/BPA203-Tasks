using System;
using _14_StatiClassExtensionMethodsExceptions.Exception;
using _14_StatiClassExtensionMethodsExceptions.Models;
namespace _14_StatiClassExtensionMethodsExceptions.Exception
{
    public class IncorrectPasswordException : System.Exception
    {
        public int AttemptsLeft { get; }

        public IncorrectPasswordException(int attemptsLeft)
            : base($"Incorrect password. Attempts left: {attemptsLeft}")
        {
            AttemptsLeft = attemptsLeft;
        }
    }
}
