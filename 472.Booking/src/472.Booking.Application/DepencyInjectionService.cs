using _472.Booking.Application.Configuration;
using _472.Booking.Application.DataBase.Bookings.Commands.CreateBooking;
using _472.Booking.Application.DataBase.Bookings.Queries.GetAllBookings;
using _472.Booking.Application.DataBase.Bookings.Queries.GetBookingByType;
using _472.Booking.Application.DataBase.Bookings.Queries.GetBookingDocumentNumber;
using _472.Booking.Application.DataBase.Customer.Commands.CreateCustomer;
using _472.Booking.Application.DataBase.Customer.Commands.DeleteCustomer;
using _472.Booking.Application.DataBase.Customer.Commands.UpdateCustomer;
using _472.Booking.Application.DataBase.Customer.Queries.GetAllCustomer;
using _472.Booking.Application.DataBase.Customer.Queries.GetCustoerGetId;
using _472.Booking.Application.DataBase.Customer.Queries.GetCustomerByDocumentNumber;
using _472.Booking.Application.DataBase.User.Commands.CreateUser;
using _472.Booking.Application.DataBase.User.Commands.DeleteUser;
using _472.Booking.Application.DataBase.User.Commands.UpdateUser;
using _472.Booking.Application.DataBase.User.Commands.UpdateUserPassword;
using _472.Booking.Application.DataBase.User.Queries.GetAllUser;
using _472.Booking.Application.DataBase.User.Queries.GetUserById;
using _472.Booking.Application.DataBase.User.Queries.GetUserByUserNameAndPassword;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace _472.Booking.Application
{
    public static class DepencyInjectionService
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var mapper = new MapperConfiguration(config =>
            {
                config.AddProfile(new MapperProfile());
            });

            #region User
                services.AddSingleton(mapper.CreateMapper());
                services.AddTransient<ICreateUserCommand, CreateUserCommand>();
                services.AddTransient<IUpdateUserCommand, UpdateUserCommand>();
                services.AddTransient<IDeleteUserCommand, DeleteUserCommand>();
                services.AddTransient<IUpdateUserPasswordCommand, UpdateUserPasswordCommand>();
                services.AddTransient<IGetAllUserQuery, GetAllUserQuery>();
                services.AddTransient<IGetUserByIdQuery, GetUserByIdQuery>();
                services.AddTransient<IGetUserByUserNameAndPasswordQuery, GetUserByUserNameAndPasswordQuery>();
            #endregion

            #region Customer
                services.AddTransient<ICreateCustomerCommand, CreateCustomerCommand>();
                services.AddTransient<IUpdateCustomerCommand, UpdateCustomerCommand>();
                services.AddTransient<IDeleteCustomerCommad, DeleteCustomerCommad>();
                services.AddTransient<IGetAllCustomerQuery, GetAllCustomerQuery>();
                services.AddTransient<IGetCustomerByIdQuery, GetCustomerByIdQuery>();
                services.AddTransient<IGetCustomerByDocumentNumberQuery, GetCustomerByDocumentNumberQuery>();
            #endregion

            #region Booking
                services.AddTransient<ICreateBookingCommand, CreateBookingCommand>();
                services.AddTransient<IGetAllBookingsQuery, GetAllBookingsQuery>();
                services.AddTransient<IGetBookingDocumentNumberQuery, GetBookingDocumentNumberQuery>();
                services.AddTransient<IGetBookingByTypeQuery, GetBookingByTypeQuery>();
            #endregion
            return services;
        }
    }
}
