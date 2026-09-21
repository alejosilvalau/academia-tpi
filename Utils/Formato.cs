using System.Globalization;

namespace Utils
{
    public static class Formato
    {
        public static string ToTitleCase(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) return texto;
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(texto.ToLower());
        }
    }
}
