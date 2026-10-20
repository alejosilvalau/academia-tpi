using System.Net;

namespace Contratos
{
    public class ApiException : Exception
    {
        public HttpStatusCode StatusCode { get; }

        public ApiException(HttpStatusCode statusCode, string mensaje)
            : base(mensaje)
        {
            StatusCode = statusCode;
        }
    }
}
