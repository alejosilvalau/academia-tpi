namespace Contratos
{
    public class PersonaClient : ApiClientBase
    {
        public PersonaClient(HttpClient http, IApiTokenProvider tokenProvider) : base(http, tokenProvider) { }

        public Task<List<PersonaDto>> GetAllAsync() => GetAsync<List<PersonaDto>>("api/personas");

        public Task<PersonaDto?> GetOneAsync(int id) => GetOrNullAsync<PersonaDto>($"api/personas/{id}");

        public Task<PersonaDto?> GetBasicoAsync(int id) => GetOrNullAsync<PersonaDto>($"api/personas/basico/{id}");

        public Task<List<PersonaDto>> GetByTipoAsync(TipoPersona tipo) => GetAsync<List<PersonaDto>>($"api/personas/por-tipo/{tipo}");

        public Task<PersonaDto?> GetByLegajoAsync(int legajo) => GetOrNullAsync<PersonaDto>($"api/personas/por-legajo/{legajo}");

        public Task<PersonaDto> SaveAsync(PersonaRequest persona) => PostAsync<PersonaDto>("api/personas", persona);

        public Task<PersonaDto> UpdateAsync(int id, PersonaRequest persona) => PutAsync<PersonaDto>($"api/personas/{id}", persona);

        public Task DeleteAsync(int id) => DeleteAsync($"api/personas/{id}");
    }

    public class UsuarioClient : ApiClientBase
    {
        public UsuarioClient(HttpClient http, IApiTokenProvider tokenProvider) : base(http, tokenProvider) { }

        public Task<List<UsuarioDto>> GetAllAsync() => GetAsync<List<UsuarioDto>>("api/usuarios");

        public Task<UsuarioDto?> GetOneAsync(int id) => GetOrNullAsync<UsuarioDto>($"api/usuarios/{id}");

        public Task<UsuarioDto?> GetByUsernameAsync(string nombreUsuario) => GetOrNullAsync<UsuarioDto>($"api/usuarios/por-usuario/{nombreUsuario}");

        public Task<UsuarioDto> SaveAsync(UsuarioRequest usuario) => PostAsync<UsuarioDto>("api/usuarios", usuario);

        public Task<UsuarioDto> UpdateAsync(int id, UsuarioRequest usuario) => PutAsync<UsuarioDto>($"api/usuarios/{id}", usuario);

        public Task DeleteAsync(int id) => DeleteAsync($"api/usuarios/{id}");
    }
}
