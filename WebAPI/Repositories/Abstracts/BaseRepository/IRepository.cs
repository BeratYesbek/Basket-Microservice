namespace WebAPI.Repositories.Abstracts.BaseRepository
{
    public interface IRepository<T>
    {
        T Create(T entity);
        T Update(T entity);
        List<T> GetAll();
        T GetById(int id);
        void Delete(int id);
    }
}
