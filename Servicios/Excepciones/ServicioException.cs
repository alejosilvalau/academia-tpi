namespace Servicios.Excepciones
{
    public class ServicioException : Exception
    {
        public ServicioException(string mensaje) : base(mensaje) { }
        public ServicioException(string mensaje, Exception innerException) : base(mensaje, innerException) { }
    }
}
