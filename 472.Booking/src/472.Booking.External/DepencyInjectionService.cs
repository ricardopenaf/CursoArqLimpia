using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace _472.Booking.External
{
    public static class DepencyInjectionService
    {
        public static IServiceCollection AddExternal(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }
    }
}
