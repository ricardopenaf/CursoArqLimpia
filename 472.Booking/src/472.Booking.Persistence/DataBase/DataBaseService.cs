using _472.Booking.Application.Interfaces;
using _472.Booking.Domain.Enetities.Booking;
using _472.Booking.Domain.Enetities.Customer;
using _472.Booking.Domain.Enetities.User;
using _472.Booking.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _472.Booking.Persistence.DataBase
{
    public class DataBaseService : DbContext, IDataBaseService
    {
        public DataBaseService(DbContextOptions options) : base(options)
        {

        }

        public DbSet<UserEntity> User { get; set; }
        public DbSet<BookingEntity> Booking { get; set; }
        public DbSet<CustomerEntity> Customer { get; set; }

        public async Task<bool> SaveAsync()
        {
            return await SaveChangesAsync() > 0;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EntityConfiguration(modelBuilder);
        }

        private void EntityConfiguration(ModelBuilder modelBuilder)
        {
            new UserConfiguration(modelBuilder.Entity<UserEntity>());
            new BookingConfiguration(modelBuilder.Entity<BookingEntity>());
            new CustomerConfiguration(modelBuilder.Entity<CustomerEntity>());
        }
    }
}
