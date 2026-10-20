namespace Contratos
{
    public record DocenteCursoDto(
        int Id,
        CargoDocente Cargo,
        int DocenteId,
        string? DocenteNombre,
        string? DocenteApellido,
        int? DocenteLegajo,
        int CursoId,
        int? CursoAnioCalendario,
        string? CursoMateriaDescripcion,
        string? CursoComisionDescripcion);

    public class DocenteCursoRequest
    {
        public CargoDocente Cargo { get; set; }
        public int DocenteId { get; set; }
        public int CursoId { get; set; }
    }

    public class AsignarDocenteRequest
    {
        public int DocenteId { get; set; }
        public int CursoId { get; set; }
        public CargoDocente Cargo { get; set; }
    }

    public record InscripcionDto(
        int Id,
        int AlumnoId,
        string? AlumnoNombre,
        string? AlumnoApellido,
        int? AlumnoLegajo,
        int CursoId,
        int? CursoAnioCalendario,
        string? CursoMateriaDescripcion,
        string? CursoComisionDescripcion,
        CondicionInscripcion Condicion,
        int? Nota);

    public class InscripcionRequest
    {
        public int AlumnoId { get; set; }
        public int CursoId { get; set; }
        public CondicionInscripcion Condicion { get; set; }
        public int? Nota { get; set; }
    }

    public class InscribirRequest
    {
        public int AlumnoId { get; set; }
        public int CursoId { get; set; }
    }
}
