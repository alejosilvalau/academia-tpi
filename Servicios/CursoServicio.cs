using Dominio;
using Repositorio;

namespace Servicios
{
    public class CursoServicio
    {
        private CursoRepositorio _repositorio;

        public CursoServicio(AcademiaContext context)
        {
            _repositorio = new CursoRepositorio(context);
        }

        public List<Curso> GetAll()
        {
            return _repositorio.GetAllConMateriaYComision();
        }

        public Curso? GetOne(int id)
        {
            return _repositorio.GetOneConMateriaYComision(id);
        }

        public List<Curso> GetByMateriaYComision(int materiaId, int comisionId)
        {
            return _repositorio.GetByMateriaYComision(materiaId, comisionId);
        }

        public void Save(Curso curso)
        {
            _repositorio.Add(curso);
            _repositorio.Save();
        }

        public void Update(Curso curso)
        {
            _repositorio.Update(curso);
            _repositorio.Save();
        }

        public void Delete(Curso curso)
        {
            _repositorio.Delete(curso);
            _repositorio.Save();
        }
    }
}
