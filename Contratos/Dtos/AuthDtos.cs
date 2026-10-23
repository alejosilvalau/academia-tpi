namespace Contratos
{
    public record LoginRequest(string NombreUsuario, string Clave);

    public record LoginResponse(
        string Token,
        string NombreUsuario,
        int? PersonaId,
        TipoPersona? Tipo,
        int? Legajo,
        string? Nombre,
        string? Apellido,
        bool Habilitado,
        DateTime ExpiraUtc);
}
