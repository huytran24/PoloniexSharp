namespace PoloniexSharp.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;

    public class PoloniexException : Exception
    {
        public HttpStatusCode HttpStatusCode { get; set; }

        public PoloniexException(HttpStatusCode httpStatusCode, string message) : base(message)
        {
            HttpStatusCode = httpStatusCode;
        }
    }
}
