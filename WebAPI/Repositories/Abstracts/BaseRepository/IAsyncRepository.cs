namespace WebAPI.Repositories.Abstracts.BaseRepository
{
    public interface IAsyncRepository<T>
    {
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task DeleteAsync(int id);
    }
}
