using WebAPI.Models;
using WebAPI.Repositories.Abstracts.BaseRepository;

namespace WebAPI.Repositories.Abstracts
{
    public interface IProductImageRepository : IAsyncRepository<ProductImage>, IRepository<ProductImage>
    {
    }
}
