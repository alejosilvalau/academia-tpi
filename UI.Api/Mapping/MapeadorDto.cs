using Contratos;
using Dominio;

namespace UI.Api.Mapping
{
    public static class MapeadorDto
    {
        public static EspecialidadDto ADto(this Especialidad e) => new(e.ID, e.Descripcion);
        public static Especialidad AEntidad(this EspecialidadRequest r) => new() { Descripcion = r.Descripcion };
        public static void Aplicar(this EspecialidadRequest r, Especialidad e) => e.Descripcion = r.Descripcion;

        public static PlanDto ADto(this Plan p) => new(p.ID, p.Descripcion, p.EspecialidadId, p.Especialidad?.Descripcion);
        public static Plan AEntidad(this PlanRequest r) => new() { Descripcion = r.Descripcion, EspecialidadId = r.EspecialidadId };
        public static void Aplicar(this PlanRequest r, Plan p)
        {
            p.Descripcion = r.Descripcion;
            p.EspecialidadId = r.EspecialidadId;
        }

        public static MateriaDto ADto(this Materia m) => new(m.ID, m.Descripcion, m.HorasSemanales, m.HorasTotales, m.PlanId, m.Plan?.Descripcion);
        public static Materia AEntidad(this MateriaRequest r) => new()
        {
            Descripcion = r.Descripcion,
            HorasSemanales = r.HorasSemanales,
            HorasTotales = r.HorasTotales,
            PlanId = r.PlanId
        };
        public static void Aplicar(this MateriaRequest r, Materia m)
        {
            m.Descripcion = r.Descripcion;
            m.HorasSemanales = r.HorasSemanales;
            m.HorasTotales = r.HorasTotales;
            m.PlanId = r.PlanId;
        }

        public static ComisionDto ADto(this Comision c) => new(c.ID, c.Descripcion, c.AnioEspecialidad, c.PlanId, c.Plan?.Descripcion);
        public static Comision AEntidad(this ComisionRequest r) => new()
        {
            Descripcion = r.Descripcion,
            AnioEspecialidad = r.AnioEspecialidad,
            PlanId = r.PlanId
        };
        public static void Aplicar(this ComisionRequest r, Comision c)
        {
            c.Descripcion = r.Descripcion;
            c.AnioEspecialidad = r.AnioEspecialidad;
            c.PlanId = r.PlanId;
        }

        public static CursoDto ADto(this Curso c) => new(c.ID, c.AnioCalendario, c.Cupo, c.MateriaId, c.Materia?.Descripcion, c.ComisionId, c.Comision?.Descripcion);
        public static Curso AEntidad(this CursoRequest r) => new()
        {
            AnioCalendario = r.AnioCalendario,
            Cupo = r.Cupo,
            MateriaId = r.MateriaId,
            ComisionId = r.ComisionId
        };
        public static void Aplicar(this CursoRequest r, Curso c)
        {
            c.AnioCalendario = r.AnioCalendario;
            c.Cupo = r.Cupo;
            c.MateriaId = r.MateriaId;
            c.ComisionId = r.ComisionId;
        }

        public static PersonaDto ADto(this Persona p) => new(
            p.ID, p.Nombre, p.Apellido, p.Legajo, p.EMail, p.Direccion, p.Telefono,
            p.FechaNacimiento, p.Tipo, p.PlanId, p.Plan?.Descripcion);
        public static Persona AEntidad(this PersonaRequest r) => new()
        {
            Nombre = r.Nombre,
            Apellido = r.Apellido,
            Legajo = r.Legajo,
            EMail = r.EMail,
            Direccion = r.Direccion,
            Telefono = r.Telefono,
            FechaNacimiento = r.FechaNacimiento,
            Tipo = r.Tipo,
            PlanId = r.PlanId
        };
        public static void Aplicar(this PersonaRequest r, Persona p)
        {
            p.Nombre = r.Nombre;
            p.Apellido = r.Apellido;
            p.Legajo = r.Legajo;
            p.EMail = r.EMail;
            p.Direccion = r.Direccion;
            p.Telefono = r.Telefono;
            p.FechaNacimiento = r.FechaNacimiento;
            p.Tipo = r.Tipo;
            p.PlanId = r.PlanId;
        }

        public static UsuarioDto ADto(this Usuario u) => new(
            u.ID, u.NombreUsuario, u.Habilitado, u.PersonaId,
            u.Persona?.Nombre, u.Persona?.Apellido, u.Persona?.Legajo, u.Persona?.Tipo);
        public static Usuario AEntidad(this UsuarioRequest r) => new()
        {
            NombreUsuario = r.NombreUsuario,
            Clave = r.Clave ?? "",
            Habilitado = r.Habilitado,
            PersonaId = r.PersonaId
        };
        public static void Aplicar(this UsuarioRequest r, Usuario u)
        {
            u.NombreUsuario = r.NombreUsuario;
            u.Habilitado = r.Habilitado;
            u.PersonaId = r.PersonaId;
            if (!string.IsNullOrEmpty(r.Clave)) u.Clave = r.Clave;
        }

        public static DocenteCursoDto ADto(this DocenteCurso d) => new(
            d.ID, d.Cargo, d.DocenteId, d.Docente?.Nombre, d.Docente?.Apellido, d.Docente?.Legajo,
            d.CursoId, d.Curso?.AnioCalendario, d.Curso?.Materia?.Descripcion, d.Curso?.Comision?.Descripcion);
        public static DocenteCurso AEntidad(this DocenteCursoRequest r) => new()
        {
            Cargo = r.Cargo,
            DocenteId = r.DocenteId,
            CursoId = r.CursoId
        };
        public static void Aplicar(this DocenteCursoRequest r, DocenteCurso d)
        {
            d.Cargo = r.Cargo;
            d.DocenteId = r.DocenteId;
            d.CursoId = r.CursoId;
        }

        public static InscripcionDto ADto(this AlumnoInscripcion a) => new(
            a.ID, a.AlumnoId, a.Alumno?.Nombre, a.Alumno?.Apellido, a.Alumno?.Legajo,
            a.CursoId, a.Curso?.AnioCalendario, a.Curso?.Materia?.Descripcion, a.Curso?.Comision?.Descripcion,
            a.Condicion, a.Nota);
        public static AlumnoInscripcion AEntidad(this InscripcionRequest r) => new()
        {
            AlumnoId = r.AlumnoId,
            CursoId = r.CursoId,
            Condicion = r.Condicion,
            Nota = r.Nota
        };
        public static void Aplicar(this InscripcionRequest r, AlumnoInscripcion a)
        {
            a.AlumnoId = r.AlumnoId;
            a.CursoId = r.CursoId;
            a.Condicion = r.Condicion;
            a.Nota = r.Nota;
        }
    }
}
