namespace Contratos
{
    public record ReportePersonaFilaDto(int Id, string Nombre, string Apellido, int Legajo)
    {
        public string Etiqueta => $"{Apellido}, {Nombre} (Legajo {Legajo})";
    }
}
