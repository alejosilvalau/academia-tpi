namespace Contratos
{
    public class DocenteCursoClient : ApiClientBase
    {
        public DocenteCursoClient(HttpClient http, IApiTokenProvider tokenProvider) : base(http, tokenProvider) { }

        public Task<List<DocenteCursoDto>> GetAllAsync() => GetAsync<List<DocenteCursoDto>>("api/docentes-cursos");

        public Task<DocenteCursoDto?> GetOneAsync(int id) => GetOrNullAsync<DocenteCursoDto>($"api/docentes-cursos/{id}");

        public Task<List<DocenteCursoDto>> GetByDocenteAsync(int docenteId) => GetAsync<List<DocenteCursoDto>>($"api/docentes-cursos/por-docente/{docenteId}");

        public Task<List<DocenteCursoDto>> GetByCursoAsync(int cursoId) => GetAsync<List<DocenteCursoDto>>($"api/docentes-cursos/por-curso/{cursoId}");

        public Task AsignarAsync(AsignarDocenteRequest solicitud) => SendAsync("api/docentes-cursos/asignar", solicitud);

        public Task<DocenteCursoDto> UpdateAsync(int id, DocenteCursoRequest dictado) => PutAsync<DocenteCursoDto>($"api/docentes-cursos/{id}", dictado);

        public Task DeleteAsync(int id) => DeleteAsync($"api/docentes-cursos/{id}");
    }

    public class InscripcionClient : ApiClientBase
    {
        public InscripcionClient(HttpClient http, IApiTokenProvider tokenProvider) : base(http, tokenProvider) { }

        public Task<List<InscripcionDto>> GetAllAsync() => GetAsync<List<InscripcionDto>>("api/inscripciones");

        public Task<InscripcionDto?> GetOneAsync(int id) => GetOrNullAsync<InscripcionDto>($"api/inscripciones/{id}");

        public Task<List<InscripcionDto>> GetByAlumnoAsync(int alumnoId) => GetAsync<List<InscripcionDto>>($"api/inscripciones/por-alumno/{alumnoId}");

        public Task<List<InscripcionDto>> GetByCursoAsync(int cursoId) => GetAsync<List<InscripcionDto>>($"api/inscripciones/por-curso/{cursoId}");

        public Task InscribirAsync(InscribirRequest solicitud) => SendAsync("api/inscripciones/inscribir", solicitud);

        public Task<InscripcionDto> UpdateAsync(int id, InscripcionRequest inscripcion) => PutAsync<InscripcionDto>($"api/inscripciones/{id}", inscripcion);

        public Task DeleteAsync(int id) => DeleteAsync($"api/inscripciones/{id}");
    }
}
