using Contratos;

namespace UI.Desktop
{
    public static class SesionEscritorio
    {
        public static LoginResponse? Perfil { get; private set; }
        public static string? Token => Perfil?.Token;
        public static int? PersonaId => Perfil?.PersonaId;
        public static TipoPersona? Tipo => Perfil?.Tipo;
        public static DateTime? ExpiraUtc => Perfil?.ExpiraUtc;
        public static bool IsAdmin => Tipo == TipoPersona.Administrador;
        public static bool IsAlumno => Tipo == TipoPersona.Alumno;
        public static bool IsDocente => Tipo == TipoPersona.Docente;
        public static bool IsLoggedIn => Perfil != null;

        public static void Iniciar(LoginResponse perfil) => Perfil = perfil;
        public static void Invalidar() => Perfil = null;

        public sealed class TokenProvider : IApiTokenProvider
        {
            public string? Token => SesionEscritorio.Token;
        }
    }
}
