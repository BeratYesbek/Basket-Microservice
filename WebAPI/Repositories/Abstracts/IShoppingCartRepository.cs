using WebAPI.Models;
using WebAPI.Repositories.Abstracts.BaseRepository;

namespace WebAPI.Repositories.Abstracts
{
    public interface IShoppingCartRepository : IAsyncRepository<ShoppingCart>
    {
    }
}
