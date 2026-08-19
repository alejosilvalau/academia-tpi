namespace Servicios.Excepciones
{
    public class ReglaNegocioException : ServicioException
    {
        public ReglaNegocioException(string mensaje) : base(mensaje) { }
    }
}
