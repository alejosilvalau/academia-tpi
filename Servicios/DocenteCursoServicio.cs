using Dominio;
using Repositorio;

namespace Servicios
{
    public class DocenteCursoServicio
    {
        private DocenteCursoRepositorio _repositorio;

        public DocenteCursoServicio(AcademiaContext context)
        {
            _repositorio = new DocenteCursoRepositorio(context);
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
            var asignacion = new DocenteCurso
            {
                DocenteId = docenteId,
                CursoId = cursoId,
                Cargo = cargo
            };

            _repositorio.Add(asignacion);
            _repositorio.Save();
        }

        public void Update(DocenteCurso docenteCurso)
        {
            _repositorio.Update(docenteCurso);
            _repositorio.Save();
        }

        public void Delete(DocenteCurso docenteCurso)
        {
            _repositorio.Delete(docenteCurso);
            _repositorio.Save();
        }
    }
}
