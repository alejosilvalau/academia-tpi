namespace Contratos
{
    public class AuthClient : ApiClientBase
    {
        public AuthClient(HttpClient http, IApiTokenProvider tokenProvider) : base(http, tokenProvider) { }

        public async Task<LoginResponse> LoginAsync(string nombreUsuario, string clave)
        {
            return await PostAsync<LoginResponse>("api/auth/login", new LoginRequest(nombreUsuario, clave)).ConfigureAwait(false);
        }
    }
}
