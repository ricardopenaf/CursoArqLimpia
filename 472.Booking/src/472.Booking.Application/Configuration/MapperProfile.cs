using _472.Booking.Application.DataBase.Bookings.Commands.CreateBooking;
using _472.Booking.Application.DataBase.Customer.Commands.CreateCustomer;
using _472.Booking.Application.DataBase.Customer.Commands.UpdateCustomer;
using _472.Booking.Application.DataBase.Customer.Queries.GetAllCustomer;
using _472.Booking.Application.DataBase.Customer.Queries.GetCustoerGetId;
using _472.Booking.Application.DataBase.Customer.Queries.GetCustomerByDocumentNumber;
using _472.Booking.Application.DataBase.User.Commands.CreateUser;
using _472.Booking.Application.DataBase.User.Commands.UpdateUser;
using _472.Booking.Application.DataBase.User.Queries.GetAllUser;
using _472.Booking.Application.DataBase.User.Queries.GetUserById;
using _472.Booking.Application.DataBase.User.Queries.GetUserByUserNameAndPassword;
using _472.Booking.Domain.Enetities.Booking;
using _472.Booking.Domain.Enetities.Customer;
using _472.Booking.Domain.Enetities.User;
using AutoMapper;

namespace _472.Booking.Application.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            #region User
            CreateMap<UserEntity, CreateUserModel>().ReverseMap();
            CreateMap<UserEntity, UpdateUserModel>().ReverseMap();
            CreateMap<UserEntity, GetAllUserModel>().ReverseMap();
            CreateMap<UserEntity, GetUserByIdModel>().ReverseMap();
            CreateMap<UserEntity, GetUserByUserNameAndPasswordModel>().ReverseMap();
            #endregion

            #region Customer
            CreateMap<CustomerEntity, CreateCustomerModel>().ReverseMap();
            CreateMap<CustomerEntity, UpdateCustomerModel>().ReverseMap();
            CreateMap<CustomerEntity, GetAllCustomerModel>().ReverseMap();
            CreateMap<CustomerEntity, GetCustomerByIdModel>().ReverseMap();
            CreateMap<CustomerEntity, GetCustomerByDocumentNumberModel>().ReverseMap();
            #endregion

            #region Booking
            CreateMap<BookingEntity, CreateBookingModel>().ReverseMap();
            #endregion
        }
    }
}
