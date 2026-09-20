using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repositorio;
using Servicios;

namespace UI.Desktop
{
    public static class ServicioFactory
    {
        private static IDbContextFactory<AcademiaContext>? _factory;
        private static IUsuarioContexto CrearContexto() => new UsuarioContextoDesktop();

        public static void Initialize(IServiceProvider provider)
        {
            _factory = provider.GetRequiredService<IDbContextFactory<AcademiaContext>>();
        }

        public static PersonaServicio Persona() => new(_factory!.CreateDbContext(), CrearContexto());
        public static UsuarioServicio Usuario() => new(_factory!.CreateDbContext(), CrearContexto());
        public static EspecialidadServicio Especialidad() => new(_factory!.CreateDbContext(), CrearContexto());
        public static PlanServicio Plan() => new(_factory!.CreateDbContext(), CrearContexto());
        public static MateriaServicio Materia() => new(_factory!.CreateDbContext(), CrearContexto());
        public static ComisionServicio Comision() => new(_factory!.CreateDbContext(), CrearContexto());
        public static CursoServicio Curso() => new(_factory!.CreateDbContext(), CrearContexto());
        public static DocenteCursoServicio DocenteCurso() => new(_factory!.CreateDbContext(), CrearContexto());
        public static InscripcionServicio Inscripcion() => new(_factory!.CreateDbContext(), CrearContexto());
        public static ReporteServicio Reporte() => new(CrearContexto());
    }
}
