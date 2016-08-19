using System;

namespace Learn_Owin.Infrastructure
{
    public class NotImplementedCustomException : Exception
    {
        private static string message => $"Not implemented yet, but will do soon";

        public NotImplementedCustomException() : base(message)
        {
        }

        public NotImplementedCustomException(Exception innerException) : base(message, innerException)
        {

        }
    }
}
