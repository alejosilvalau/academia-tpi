using Repositorio;
using Servicios;

namespace UI.Desktop
{
    public static class ServicioFactory
    {
        private static IUsuarioContexto CrearContexto() => new UsuarioContextoDesktop();

        public static PersonaServicio Persona() => new(new AcademiaContext(), CrearContexto());
        public static UsuarioServicio Usuario() => new(new AcademiaContext(), CrearContexto());
        public static EspecialidadServicio Especialidad() => new(new AcademiaContext(), CrearContexto());
        public static PlanServicio Plan() => new(new AcademiaContext(), CrearContexto());
        public static MateriaServicio Materia() => new(new AcademiaContext(), CrearContexto());
        public static ComisionServicio Comision() => new(new AcademiaContext(), CrearContexto());
        public static CursoServicio Curso() => new(new AcademiaContext(), CrearContexto());
        public static DocenteCursoServicio DocenteCurso() => new(new AcademiaContext(), CrearContexto());
        public static InscripcionServicio Inscripcion() => new(new AcademiaContext(), CrearContexto());
        public static ReporteServicio Reporte() => new(CrearContexto());
    }
}
