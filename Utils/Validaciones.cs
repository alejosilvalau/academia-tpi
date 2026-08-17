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
    }
}
