using WebAPI.Repositories.Abstracts;
using WebAPI.Repositories.Concretes;

namespace WebAPI.Extensions
{
    public static class DependencyResolver
    {
        public static void LoadResolver(this IServiceCollection service)
        {
            service.AddSingleton<IProductRepository, ProductRepository>();
            service.AddSingleton<ICategoryRepository, CategoryRepository>();
            service.AddSingleton<IProductImageRepository, ProductImageRepository>();
            service.AddSingleton<IShoppingCartRepository, ShoppingCartRepository>();
        }
    }
}
