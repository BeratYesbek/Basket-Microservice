

using Microsoft.Extensions.Configuration;

namespace WebAPI.Extensions
{
    public static class ServiceRegistrations
    {
        public static void ServiceRegister(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = configuration.GetValue<string>("CacheSettings:ConnectionString");
            });

            service.AddAutoMapper(typeof(Program));

        }
    }
}
