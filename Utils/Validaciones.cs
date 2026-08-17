using System.Text.RegularExpressions;

namespace Utils
{
    internal class Validaciones
    {
        public static bool ValidarRegexEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-z0-9!#$%&'""*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'""*+/=?^_`{|}~-]+)*" +
                    @"@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");
        }

        public static bool ValidarRegexClave(string clave)
        {
            return Regex.IsMatch(clave, ".{4,50}");
        }

        public static bool ValidarClaveConfirmada(string clave, string conf)
        {
            return clave.Equals(conf);
        }

        public static bool ValidarRegexNombreyApellido(string texto)
        {
            return Regex.IsMatch(texto, @"^[A-Za-zÀ-ú]+([-' ][A-Za-zÀ-ú]+)*$");
        }
    }
}
