using _472.Booking.Domain.Enetities.Booking;
using _472.Booking.Domain.Enetities.Customer;
using _472.Booking.Domain.Enetities.User;
using Microsoft.EntityFrameworkCore;

namespace _472.Booking.Application.Interfaces
{
    public interface IDataBaseService
    {
        DbSet<UserEntity> User { get; set; }
        DbSet<CustomerEntity> Customer { get; set; }
        DbSet<BookingEntity> Booking { get; set; }
        Task<bool> SaveAsync();
    }
}
