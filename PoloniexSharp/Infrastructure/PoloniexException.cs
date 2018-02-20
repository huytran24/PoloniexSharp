namespace PoloniexSharp.Infrastructure
{
    using System;
    using System.Net;

    public class PoloniexException : Exception
    {
        public HttpStatusCode HttpStatusCode { get; set; }

        public PoloniexException(HttpStatusCode httpStatusCode, string message) : base(message)
        {
            HttpStatusCode = httpStatusCode;
        }
    }
}
