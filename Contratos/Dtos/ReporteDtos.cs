using System.Globalization;

namespace Contratos
{
    public record ReportePersonaFilaDto(int Id, string Nombre, string Apellido, int Legajo)
    {
        public string Etiqueta => $"{Capitalizar(Apellido)}, {Capitalizar(Nombre)} (Legajo {Legajo})";

        private static string Capitalizar(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) return texto;
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(texto.ToLower());
        }
    }
}
