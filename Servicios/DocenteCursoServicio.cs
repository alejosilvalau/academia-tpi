using Dominio;
using Repositorio;
using Servicios.Excepciones;
using Utils;

namespace Servicios
{
    public class DocenteCursoServicio : ServicioBase
    {
        private DocenteCursoRepositorio _repositorio;
        private PersonaRepositorio _personaRepositorio;

        public DocenteCursoServicio(AcademiaContext context)
        {
            _repositorio = new DocenteCursoRepositorio(context);
            _personaRepositorio = new PersonaRepositorio(context);
        }

        public List<DocenteCurso> GetAll()
        {
            return _repositorio.GetAllConCursoYDocente();
        }

        public DocenteCurso? GetOne(int id)
        {
            return _repositorio.GetOne(id);
        }

        public List<DocenteCurso> GetByDocente(int docenteId)
        {
            return _repositorio.GetByDocente(docenteId);
        }

        public List<DocenteCurso> GetByCurso(int cursoId)
        {
            return _repositorio.GetByCurso(cursoId);
        }

        public void AsignarDocente(int docenteId, int cursoId, DocenteCurso.TiposCargos cargo)
        {
            ValidarBasicos(docenteId, cursoId);
            ValidarReglasNegocio(docenteId, cursoId, cargo, esAlta: true);
            var asignacion = new DocenteCurso
            {
                DocenteId = docenteId,
                CursoId = cursoId,
                Cargo = cargo
            };
            EjecutarPersistencia(() =>
            {
                _repositorio.Add(asignacion);
                _repositorio.Save();
            }, "No se pudo asignar el docente. Intente nuevamente.");
        }

        public void Update(DocenteCurso docenteCurso)
        {
            ValidarBasicos(docenteCurso.DocenteId, docenteCurso.CursoId);
            ValidarReglasNegocio(docenteCurso.DocenteId, docenteCurso.CursoId, docenteCurso.Cargo, esAlta: false, idActual: docenteCurso.ID);
            EjecutarPersistencia(() =>
            {
                _repositorio.Update(docenteCurso);
                _repositorio.Save();
            }, "No se pudo actualizar la asignación. Intente nuevamente.");
        }

        public void Delete(DocenteCurso docenteCurso)
        {
            EjecutarPersistencia(() =>
            {
                _repositorio.Delete(docenteCurso);
                _repositorio.Save();
            }, "No se pudo eliminar la asignación. Intente nuevamente.");
        }

        private void ValidarBasicos(int docenteId, int cursoId)
        {
            Validar(() =>
            {
                Validaciones.AsegurarPositivo(docenteId, "Docente");
                Validaciones.AsegurarPositivo(cursoId, "Curso");
            });
        }

        private void ValidarReglasNegocio(int docenteId, int cursoId, DocenteCurso.TiposCargos cargo, bool esAlta, int idActual = 0)
        {
            var docente = _personaRepositorio.GetOne(docenteId);
            if (docente == null)
                throw new ReglaNegocioException("El docente especificado no existe.");
            if (docente.Tipo != Persona.TiposPersonas.Docente)
                throw new ReglaNegocioException("La persona seleccionada no es de tipo docente.");

            var duplicado = _repositorio.GetByCurso(cursoId)
                .FirstOrDefault(dc => dc.DocenteId == docenteId && dc.Cargo == cargo && dc.ID != idActual);
            if (duplicado != null)
                throw new ReglaNegocioException("Ese docente ya está asignado a ese curso con el mismo cargo.");
        }
    }
}
