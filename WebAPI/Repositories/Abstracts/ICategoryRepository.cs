using WebAPI.Models;
using WebAPI.Repositories.Abstracts.BaseRepository;

namespace WebAPI.Repositories.Abstracts
{
    public interface ICategoryRepository : IAsyncRepository<Category>,IRepository<Category>
    {
    }
}
