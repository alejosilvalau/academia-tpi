using Dominio;
using Repositorio;

namespace Servicios
{
    public class ComisionServicio
    {
        private ComisionRepositorio _repositorio;

        public ComisionServicio(AcademiaContext context)
        {
            _repositorio = new ComisionRepositorio(context);
        }

        public List<Comision> GetAll()
        {
            return _repositorio.GetAllConPlan();
        }

        public Comision? GetOne(int id)
        {
            return _repositorio.GetOne(id);
        }

        public List<Comision> GetByPlan(int planId)
        {
            return _repositorio.GetByPlan(planId);
        }

        public void Save(Comision comision)
        {
            _repositorio.Add(comision);
            _repositorio.Save();
        }

        public void Update(Comision comision)
        {
            _repositorio.Update(comision);
            _repositorio.Save();
        }

        public void Delete(Comision comision)
        {
            _repositorio.Delete(comision);
            _repositorio.Save();
        }
    }
}
