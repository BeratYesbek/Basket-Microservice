using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using WebAPI.Models;
using WebAPI.Repositories.Abstracts;

namespace WebAPI.Repositories.Concretes
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly IDistributedCache _cache;
        public ShoppingCartRepository(IDistributedCache cache)
        {
            _cache = cache;
        }
        public async Task CreateAsync(ShoppingCart entity)
        {
            var jsonValue = JsonConvert.SerializeObject(entity);
            await _cache.SetStringAsync(entity.Username, jsonValue);
        }

        public async Task UpdateAsync(ShoppingCart entity)
        {
            var jsonValue = JsonConvert.SerializeObject(entity);
            await _cache.SetStringAsync(entity.Username, jsonValue);
        }

        public async Task<ShoppingCart> GetByUsernameAsync(string username)
        {
            var value = await _cache.GetStringAsync(username);
            if (string.IsNullOrEmpty(value))
            {
                return null!;
            }
            return JsonConvert.DeserializeObject<ShoppingCart>(value)!;
        }

        public async Task DeleteAsync(string username)
        {
            await _cache.RemoveAsync(username);
        }

    }
}
