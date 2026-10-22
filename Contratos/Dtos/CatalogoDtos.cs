namespace Contratos
{
    public class EspecialidadRequest
    {
        public string Descripcion { get; set; } = "";
    }

    public class PlanRequest
    {
        public string Descripcion { get; set; } = "";
        public int EspecialidadId { get; set; }
    }

    public class MateriaRequest
    {
        public string Descripcion { get; set; } = "";
        public int HorasSemanales { get; set; }
        public int HorasTotales { get; set; }
        public int PlanId { get; set; }
    }

    public class ComisionRequest
    {
        public string Descripcion { get; set; } = "";
        public int AnioEspecialidad { get; set; }
        public int PlanId { get; set; }
    }

    public class CursoRequest
    {
        public int AnioCalendario { get; set; }
        public int Cupo { get; set; }
        public int MateriaId { get; set; }
        public int ComisionId { get; set; }
    }

    public record EspecialidadDto(int Id, string Descripcion);

    public record PlanDto(int Id, string Descripcion, int EspecialidadId, string? EspecialidadDescripcion);

    public record MateriaDto(int Id, string Descripcion, int HorasSemanales, int HorasTotales, int PlanId, string? PlanDescripcion);

    public record ComisionDto(int Id, string Descripcion, int AnioEspecialidad, int PlanId, string? PlanDescripcion);

    public record CursoDto(int Id, int AnioCalendario, int Cupo, int MateriaId, string? MateriaDescripcion, int ComisionId, string? ComisionDescripcion);
}
