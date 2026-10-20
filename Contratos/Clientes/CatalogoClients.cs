namespace Contratos
{
    public class EspecialidadClient : ApiClientBase
    {
        public EspecialidadClient(HttpClient http, IApiTokenProvider tokenProvider) : base(http, tokenProvider) { }

        public Task<List<EspecialidadDto>> GetAllAsync() => GetAsync<List<EspecialidadDto>>("api/especialidades");

        public Task<EspecialidadDto?> GetOneAsync(int id) => GetOrNullAsync<EspecialidadDto>($"api/especialidades/{id}");

        public Task<EspecialidadDto> SaveAsync(EspecialidadRequest especialidad) => PostAsync<EspecialidadDto>("api/especialidades", especialidad);

        public Task<EspecialidadDto> UpdateAsync(int id, EspecialidadRequest especialidad) => PutAsync<EspecialidadDto>($"api/especialidades/{id}", especialidad);

        public Task DeleteAsync(int id) => DeleteAsync($"api/especialidades/{id}");
    }

    public class PlanClient : ApiClientBase
    {
        public PlanClient(HttpClient http, IApiTokenProvider tokenProvider) : base(http, tokenProvider) { }

        public Task<List<PlanDto>> GetAllAsync() => GetAsync<List<PlanDto>>("api/planes");

        public Task<PlanDto?> GetOneAsync(int id) => GetOrNullAsync<PlanDto>($"api/planes/{id}");

        public Task<List<PlanDto>> GetByEspecialidadAsync(int especialidadId) => GetAsync<List<PlanDto>>($"api/planes/por-especialidad/{especialidadId}");

        public Task<PlanDto> SaveAsync(PlanRequest plan) => PostAsync<PlanDto>("api/planes", plan);

        public Task<PlanDto> UpdateAsync(int id, PlanRequest plan) => PutAsync<PlanDto>($"api/planes/{id}", plan);

        public Task DeleteAsync(int id) => DeleteAsync($"api/planes/{id}");
    }

    public class MateriaClient : ApiClientBase
    {
        public MateriaClient(HttpClient http, IApiTokenProvider tokenProvider) : base(http, tokenProvider) { }

        public Task<List<MateriaDto>> GetAllAsync() => GetAsync<List<MateriaDto>>("api/materias");

        public Task<MateriaDto?> GetOneAsync(int id) => GetOrNullAsync<MateriaDto>($"api/materias/{id}");

        public Task<List<MateriaDto>> GetByPlanAsync(int planId) => GetAsync<List<MateriaDto>>($"api/materias/por-plan/{planId}");

        public Task<MateriaDto> SaveAsync(MateriaRequest materia) => PostAsync<MateriaDto>("api/materias", materia);

        public Task<MateriaDto> UpdateAsync(int id, MateriaRequest materia) => PutAsync<MateriaDto>($"api/materias/{id}", materia);

        public Task DeleteAsync(int id) => DeleteAsync($"api/materias/{id}");
    }

    public class ComisionClient : ApiClientBase
    {
        public ComisionClient(HttpClient http, IApiTokenProvider tokenProvider) : base(http, tokenProvider) { }

        public Task<List<ComisionDto>> GetAllAsync() => GetAsync<List<ComisionDto>>("api/comisiones");

        public Task<ComisionDto?> GetOneAsync(int id) => GetOrNullAsync<ComisionDto>($"api/comisiones/{id}");

        public Task<List<ComisionDto>> GetByPlanAsync(int planId) => GetAsync<List<ComisionDto>>($"api/comisiones/por-plan/{planId}");

        public Task<ComisionDto> SaveAsync(ComisionRequest comision) => PostAsync<ComisionDto>("api/comisiones", comision);

        public Task<ComisionDto> UpdateAsync(int id, ComisionRequest comision) => PutAsync<ComisionDto>($"api/comisiones/{id}", comision);

        public Task DeleteAsync(int id) => DeleteAsync($"api/comisiones/{id}");
    }

    public class CursoClient : ApiClientBase
    {
        public CursoClient(HttpClient http, IApiTokenProvider tokenProvider) : base(http, tokenProvider) { }

        public Task<List<CursoDto>> GetAllAsync() => GetAsync<List<CursoDto>>("api/cursos");

        public Task<CursoDto?> GetOneAsync(int id) => GetOrNullAsync<CursoDto>($"api/cursos/{id}");

        public Task<List<CursoDto>> GetByMateriaYComisionAsync(int materiaId, int comisionId)
            => GetAsync<List<CursoDto>>($"api/cursos/por-materia-comision?materiaId={materiaId}&comisionId={comisionId}");

        public Task<CursoDto> SaveAsync(CursoRequest curso) => PostAsync<CursoDto>("api/cursos", curso);

        public Task<CursoDto> UpdateAsync(int id, CursoRequest curso) => PutAsync<CursoDto>($"api/cursos/{id}", curso);

        public Task DeleteAsync(int id) => DeleteAsync($"api/cursos/{id}");
    }
}
