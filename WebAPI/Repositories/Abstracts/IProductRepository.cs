using WebAPI.Models;
using WebAPI.Repositories.Abstracts.BaseRepository;

namespace WebAPI.Repositories.Abstracts
{
    public interface IProductRepository : IAsyncRepository<Product>,IRepository<Product>
    {
    }
}
