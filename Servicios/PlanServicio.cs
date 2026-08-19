using Dominio;
using Repositorio;

namespace Servicios
{
    public class PlanServicio
    {
        private PlanRepositorio _repositorio;

        public PlanServicio(AcademiaContext context)
        {
            _repositorio = new PlanRepositorio(context);
        }

        public List<Plan> GetAll()
        {
            return _repositorio.GetAllConEspecialidad();
        }

        public Plan? GetOne(int id)
        {
            return _repositorio.GetOne(id);
        }

        public List<Plan> GetByEspecialidad(int especialidadId)
        {
            return _repositorio.GetByEspecialidad(especialidadId);
        }

        public void Save(Plan plan)
        {
            _repositorio.Add(plan);
            _repositorio.Save();
        }

        public void Update(Plan plan)
        {
            _repositorio.Update(plan);
            _repositorio.Save();
        }

        public void Delete(Plan plan)
        {
            _repositorio.Delete(plan);
            _repositorio.Save();
        }
    }
}
