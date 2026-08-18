using Microsoft.EntityFrameworkCore;

namespace Repositorio
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        protected AcademiaContext context;

        public Repositorio(AcademiaContext ctx)
        {
            context = ctx;
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T? GetOne(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
