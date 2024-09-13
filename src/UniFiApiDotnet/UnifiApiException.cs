using System;

namespace UniFiApiDotnet
{
    public class UnifiApiException : Exception
    {
        public UnifiApiException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}