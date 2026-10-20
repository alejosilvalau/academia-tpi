namespace Contratos
{
    public class ReporteClient : ApiClientBase
    {
        public ReporteClient(HttpClient http, IApiTokenProvider tokenProvider) : base(http, tokenProvider) { }

        public Task<List<ReportePersonaFilaDto>> GetDocentesAsync()
            => GetAsync<List<ReportePersonaFilaDto>>("api/reportes/docentes");

        public Task<List<ReportePersonaFilaDto>> GetAlumnosAsync()
            => GetAsync<List<ReportePersonaFilaDto>>("api/reportes/alumnos");

        public Task<List<ReportePersonaFilaDto>> GetAlumnosDeDocenteAsync(int docenteId)
            => GetAsync<List<ReportePersonaFilaDto>>($"api/reportes/alumnos-de-docente/{docenteId}");

        public Task<byte[]> GetRendimientoDocentePdfAsync(int docenteId)
            => GetBytesAsync($"api/reportes/rendimiento-docente/{docenteId}/pdf");

        public Task<byte[]> GetRendimientoAlumnoPdfAsync(int alumnoId)
            => GetBytesAsync($"api/reportes/rendimiento-alumno/{alumnoId}/pdf");

        public Task<byte[]> GetRendimientosAlumnosDocentePdfAsync(int docenteId)
            => GetBytesAsync($"api/reportes/rendimiento-alumnos-docente/{docenteId}/pdf");
    }
}
