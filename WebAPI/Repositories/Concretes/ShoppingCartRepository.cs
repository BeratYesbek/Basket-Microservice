using WebAPI.Models;
using WebAPI.Repositories.Abstracts;

namespace WebAPI.Repositories.Concretes
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        public ShoppingCartRepository()
        {
            
        }
        public Task<ShoppingCart> CreateAsync(ShoppingCart entity)
        {
            throw new NotImplementedException();
        }

        public Task<ShoppingCart> UpdateAsync(ShoppingCart entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<ShoppingCart>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ShoppingCart> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
