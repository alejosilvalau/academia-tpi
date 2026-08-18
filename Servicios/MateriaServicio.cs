using Dominio;
using Repositorio;

namespace Servicios
{
    public class MateriaServicio
    {
        private MateriaRepositorio _repositorio;

        public MateriaServicio(AcademiaContext context)
        {
            _repositorio = new MateriaRepositorio(context);
        }

        public List<Materia> GetAll()
        {
            return _repositorio.GetAll();
        }

        public Materia? GetOne(int id)
        {
            return _repositorio.GetOne(id);
        }

        public List<Materia> GetByPlan(int planId)
        {
            return _repositorio.GetByPlan(planId);
        }

        public void Save(Materia materia)
        {
            _repositorio.Add(materia);
            _repositorio.Save();
        }

        public void Update(Materia materia)
        {
            _repositorio.Update(materia);
            _repositorio.Save();
        }

        public void Delete(Materia materia)
        {
            _repositorio.Delete(materia);
            _repositorio.Save();
        }
    }
}
