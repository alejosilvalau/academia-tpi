using System.Text.RegularExpressions;

namespace Utils
{
    public class Validaciones
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

        public static bool ValidarClave(string clave_usr, string txt_clave)
        {
            if (string.IsNullOrEmpty(clave_usr) || !clave_usr.Equals(txt_clave))
            {
                return false;
            }
            return true;
        }

        public static bool ValidarRegexNombreyApellido(string texto)
        {
            return Regex.IsMatch(texto, @"^[A-Za-zÀ-ú]+([-' ][A-Za-zÀ-ú]+)*$");
        }

        public static bool FormularioCompleto(List<string> txts)
        {
            bool rta = true;
            txts.ForEach(t =>
            {
                if (string.IsNullOrEmpty(t))
                {
                    rta = false;
                }
            });
            return rta;
        }

        public static bool UsuarioLengthValido(string nombreUsuario)
        {
            if (nombreUsuario.Length > 15)
            {
                return false;
            }
            return true;
        }

        public static bool ValidarRegexTelefono(string telefono)
        {
            return Regex.IsMatch(telefono, @"^[\d\s\+\-\(\)]{6,30}$");
        }

        public static bool ValidarRegexDescripcion(string descripcion)
        {
            return Regex.IsMatch(descripcion, @"^[\p{L}\p{N}\s\.\,\-\(\)\'\:]+$");
        }

        public static bool ValidarEnteroParseable(string texto)
        {
            return int.TryParse(texto, out _);
        }

        public static void AsegurarNoVacio(string? valor, string campo)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new ArgumentException($"El campo {campo} es obligatorio.");
            }
        }

        public static void AsegurarEnteroParseable(string? texto, string campo)
        {
            if (string.IsNullOrWhiteSpace(texto) || !int.TryParse(texto, out _))
            {
                throw new ArgumentException($"El campo {campo} debe ser un número entero válido.");
            }
        }

        public static void AsegurarEmail(string? email)
        {
            if (string.IsNullOrWhiteSpace(email) || !ValidarRegexEmail(email))
            {
                throw new ArgumentException("El email ingresado no es válido.");
            }
        }

        public static void AsegurarNombreOApellido(string? texto, string campo)
        {
            if (string.IsNullOrWhiteSpace(texto) || !ValidarRegexNombreyApellido(texto))
            {
                throw new ArgumentException($"El campo {campo} solo puede contener letras.");
            }
        }

        public static void AsegurarClave(string? clave)
        {
            if (string.IsNullOrWhiteSpace(clave) || !ValidarRegexClave(clave))
            {
                throw new ArgumentException("La clave debe tener entre 4 y 50 caracteres.");
            }
        }

        public static void AsegurarLongitudUsuario(string? nombreUsuario)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario) || nombreUsuario.Contains(' ') || !UsuarioLengthValido(nombreUsuario))
            {
                throw new ArgumentException("El nombre de usuario no puede contener espacios y debe tener hasta 15 caracteres.");
            }
        }

        public static void AsegurarTelefono(string? telefono)
        {
            if (string.IsNullOrWhiteSpace(telefono) || !ValidarRegexTelefono(telefono))
            {
                throw new ArgumentException("El teléfono ingresado no es válido.");
            }
        }

        public static void AsegurarDescripcion(string? descripcion, string campo)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                throw new ArgumentException($"El campo {campo} es obligatorio.");
            }
            if (descripcion.Length > 100)
            {
                throw new ArgumentException($"El campo {campo} no puede superar los 100 caracteres.");
            }
            if (!ValidarRegexDescripcion(descripcion))
            {
                throw new ArgumentException($"El campo {campo} contiene caracteres no permitidos.");
            }
        }

        public static void AsegurarRangoEntero(int valor, int min, int max, string campo)
        {
            if (valor < min || valor > max)
            {
                throw new ArgumentException($"El campo {campo} debe estar entre {min} y {max}.");
            }
        }

        public static void AsegurarPositivo(int valor, string campo)
        {
            if (valor <= 0)
            {
                throw new ArgumentException($"El campo {campo} debe ser un número positivo.");
            }
        }

    }
}
