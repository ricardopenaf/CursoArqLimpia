using _472.Booking.Application.Interfaces;
using _472.Booking.Persistence.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace _472.Booking.Persistence
{
    public static class DepencyInjectionService
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataBaseService>(options => options.UseSqlServer(configuration["ConnectionStrings"]));
            services.AddScoped<IDataBaseService, DataBaseService>();

            return services;
        }
    }
}
