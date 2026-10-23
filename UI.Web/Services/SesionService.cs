using System.Security.Claims;
using System.Threading;
using Contratos;
using Microsoft.AspNetCore.Components.Authorization;

namespace UI.Web.Services
{
    public class SesionService : AuthenticationStateProvider, IApiTokenProvider, IDisposable
    {
        private LoginResponse? _sesion;
        private CancellationTokenSource? _expiracionCts;

        public string? Token => _sesion?.Token;
        public LoginResponse? Perfil => _sesion;
        public int? PersonaId => _sesion?.PersonaId;
        public TipoPersona? TipoUsuario => _sesion?.Tipo;
        public string? NombreUsuario => _sesion?.NombreUsuario;
        public DateTime? ExpiraUtc => _sesion?.ExpiraUtc;
        public bool IsLoggedIn => _sesion != null;
        public bool SesionExpirada { get; private set; }
        public bool IsAdmin => TipoUsuario == TipoPersona.Administrador;
        public bool IsAlumno => TipoUsuario == TipoPersona.Alumno;
        public bool IsDocente => TipoUsuario == TipoPersona.Docente;

        public bool ValidarPermisos(TipoPersona tipoRequerido) => IsAdmin || TipoUsuario == tipoRequerido;

        public void Iniciar(LoginResponse sesion)
        {
            SesionExpirada = false;
            _sesion = sesion;
            ProgramarExpiracion(sesion.ExpiraUtc);
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }

        public void Invalidar() => CerrarSesion(false);

        private void Expirar() => CerrarSesion(true);

        private void CerrarSesion(bool expirada)
        {
            CancelarExpiracion();
            _sesion = null;
            SesionExpirada = expirada;
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }

        private void ProgramarExpiracion(DateTime expiraUtc)
        {
            CancelarExpiracion();
            if (expiraUtc == default) return;

            var cts = new CancellationTokenSource();
            _expiracionCts = cts;
            _ = ExpirarAlVencerAsync(expiraUtc, cts);
        }

        private async Task ExpirarAlVencerAsync(DateTime expiraUtc, CancellationTokenSource cts)
        {
            try
            {
                var demora = expiraUtc - DateTime.UtcNow;
                if (demora > TimeSpan.Zero)
                    await Task.Delay(demora, cts.Token);

                if (!cts.IsCancellationRequested)
                    Expirar();
            }
            catch (OperationCanceledException)
            {
            }
        }

        private void CancelarExpiracion()
        {
            var cts = _expiracionCts;
            _expiracionCts = null;
            if (cts == null) return;

            cts.Cancel();
            cts.Dispose();
        }

        public void Dispose() => CancelarExpiracion();

        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            return Task.FromResult(new AuthenticationState(ConstruirPrincipal(_sesion)));
        }

        private static ClaimsPrincipal ConstruirPrincipal(LoginResponse? sesion)
        {
            if (sesion == null)
            {
                return new ClaimsPrincipal(new ClaimsIdentity());
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, sesion.NombreUsuario),
                new Claim(ClaimTypes.NameIdentifier, (sesion.PersonaId ?? 0).ToString()),
                new Claim(ClaimTypes.Role, (sesion.Tipo ?? TipoPersona.Alumno).ToString()),
                new Claim("Nombre", sesion.Nombre ?? ""),
                new Claim("Apellido", sesion.Apellido ?? ""),
                new Claim("Legajo", (sesion.Legajo ?? 0).ToString()),
                new Claim("PersonaId", (sesion.PersonaId ?? 0).ToString())
            };
            return new ClaimsPrincipal(new ClaimsIdentity(claims, "AcademiaTPI.Api"));
        }
    }
}
