namespace Repositorio
{
    public interface IRepositorio<T> where T : class
    {
        List<T> GetAll();
        T? GetOne(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
    }
}
