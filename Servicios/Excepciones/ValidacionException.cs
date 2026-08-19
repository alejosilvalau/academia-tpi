namespace Servicios.Excepciones
{
    public class ValidacionException : ServicioException
    {
        public string? Campo { get; }

        public ValidacionException(string mensaje, string? campo = null) : base(mensaje)
        {
            Campo = campo;
        }
    }
}
