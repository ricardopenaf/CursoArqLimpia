using _472.Booking.Application.Interfaces;

namespace _472.Booking.Application.DataBase.User.Commands.DeleteUser
{
    public interface IDeleteUserCommand
    {
        Task<bool> Execute(int UserId);
    }
}
