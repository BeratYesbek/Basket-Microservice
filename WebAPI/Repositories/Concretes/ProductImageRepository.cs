using WebAPI.Models;
using WebAPI.Repositories.Abstracts;

namespace WebAPI.Repositories.Concretes
{
    public class ProductImageRepository : IProductImageRepository
    {
        public Task<ProductImage> CreateAsync(ProductImage entity)
        {
            throw new NotImplementedException();
        }

        public Task<ProductImage> UpdateAsync(ProductImage entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductImage>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProductImage> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public ProductImage Create(ProductImage entity)
        {
            throw new NotImplementedException();
        }

        public ProductImage Update(ProductImage entity)
        {
            throw new NotImplementedException();
        }

        public List<ProductImage> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProductImage GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
