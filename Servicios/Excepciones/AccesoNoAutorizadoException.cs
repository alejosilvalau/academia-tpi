namespace Servicios.Excepciones
{
    public class AccesoNoAutorizadoException : ServicioException
    {
        public AccesoNoAutorizadoException(string mensaje) : base(mensaje) { }
    }
}
