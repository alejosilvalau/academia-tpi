namespace Contratos
{
    public record PersonaDto(
        int Id,
        string Nombre,
        string Apellido,
        int Legajo,
        string EMail,
        string Direccion,
        string Telefono,
        DateTime FechaNacimiento,
        TipoPersona Tipo,
        int? PlanId,
        string? PlanDescripcion);

    public class PersonaRequest
    {
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
        public int Legajo { get; set; }
        public string EMail { get; set; } = "";
        public string Direccion { get; set; } = "";
        public string Telefono { get; set; } = "";
        public DateTime FechaNacimiento { get; set; }
        public TipoPersona Tipo { get; set; }
        public int? PlanId { get; set; }
    }

    public record UsuarioDto(
        int Id,
        string NombreUsuario,
        bool Habilitado,
        int? PersonaId,
        string? PersonaNombre,
        string? PersonaApellido,
        int? PersonaLegajo,
        TipoPersona? PersonaTipo);

    public class UsuarioRequest
    {
        public string NombreUsuario { get; set; } = "";
        public string? Clave { get; set; }
        public bool Habilitado { get; set; } = true;
        public int? PersonaId { get; set; }
    }
}
