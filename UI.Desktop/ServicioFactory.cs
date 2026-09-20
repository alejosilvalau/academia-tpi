using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositorio;
using Servicios;

namespace UI.Desktop
{
    public static class ServicioFactory
    {
        private static IDbContextFactory<AcademiaContext>? _factory;
        private static IUsuarioContexto _contexto = new UsuarioContextoDesktop();
        private static IConfiguration? _configuration;

        public static void Initialize(IServiceProvider provider)
        {
            _factory = provider.GetRequiredService<IDbContextFactory<AcademiaContext>>();
            _configuration = provider.GetRequiredService<IConfiguration>();
        }

        public static PersonaServicio Persona() => new(_factory!.CreateDbContext(), _contexto);
        public static UsuarioServicio Usuario() => new(_factory!.CreateDbContext(), _contexto);
        public static EspecialidadServicio Especialidad() => new(_factory!.CreateDbContext(), _contexto);
        public static PlanServicio Plan() => new(_factory!.CreateDbContext(), _contexto);
        public static MateriaServicio Materia() => new(_factory!.CreateDbContext(), _contexto);
        public static ComisionServicio Comision() => new(_factory!.CreateDbContext(), _contexto);
        public static CursoServicio Curso() => new(_factory!.CreateDbContext(), _contexto);
        public static DocenteCursoServicio DocenteCurso() => new(_factory!.CreateDbContext(), _contexto);
        public static InscripcionServicio Inscripcion() => new(_factory!.CreateDbContext(), _contexto);
        public static ReporteServicio Reporte() => new(_contexto, _configuration!);
    }
}
