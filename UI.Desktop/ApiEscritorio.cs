using Contratos;

namespace UI.Desktop
{
    public static class ApiEscritorio
    {
        public static AuthClient Auth { get; private set; } = null!;
        public static EspecialidadClient Especialidad { get; private set; } = null!;
        public static PlanClient Plan { get; private set; } = null!;
        public static MateriaClient Materia { get; private set; } = null!;
        public static ComisionClient Comision { get; private set; } = null!;
        public static CursoClient Curso { get; private set; } = null!;
        public static PersonaClient Persona { get; private set; } = null!;
        public static UsuarioClient Usuario { get; private set; } = null!;
        public static DocenteCursoClient DocenteCurso { get; private set; } = null!;
        public static InscripcionClient Inscripcion { get; private set; } = null!;
        public static ReporteClient Reporte { get; private set; } = null!;

        public static void Inicializar(string baseUrl)
        {
            var http = new HttpClient { BaseAddress = new Uri(baseUrl) };
            var tokenProvider = new SesionEscritorio.TokenProvider();

            Auth = new AuthClient(http, tokenProvider);
            Especialidad = new EspecialidadClient(http, tokenProvider);
            Plan = new PlanClient(http, tokenProvider);
            Materia = new MateriaClient(http, tokenProvider);
            Comision = new ComisionClient(http, tokenProvider);
            Curso = new CursoClient(http, tokenProvider);
            Persona = new PersonaClient(http, tokenProvider);
            Usuario = new UsuarioClient(http, tokenProvider);
            DocenteCurso = new DocenteCursoClient(http, tokenProvider);
            Inscripcion = new InscripcionClient(http, tokenProvider);
            Reporte = new ReporteClient(http, tokenProvider);
        }
    }
}
