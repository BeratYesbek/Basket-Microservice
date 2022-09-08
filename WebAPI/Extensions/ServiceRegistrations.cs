using Microsoft.EntityFrameworkCore;
using WebAPI.Data;

namespace WebAPI.Extensions
{
    public static class ServiceRegistrations
    {
        public static void ServiceRegister(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<BasketDbContext>(opt => opt.UseSqlServer(
                configuration.GetConnectionString("BasketConnectionString")
                ));

        }
    }
}
