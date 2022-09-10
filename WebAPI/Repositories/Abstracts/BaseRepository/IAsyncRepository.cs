namespace WebAPI.Repositories.Abstracts
{
    public interface IAsyncRepository<T>
    {
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task<T> GetByUsernameAsync(string username);
        Task DeleteAsync(string username);
    }
}
