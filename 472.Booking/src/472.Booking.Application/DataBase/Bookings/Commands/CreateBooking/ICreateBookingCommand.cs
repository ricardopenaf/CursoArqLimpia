namespace _472.Booking.Application.DataBase.Bookings.Commands.CreateBooking
{
    public interface ICreateBookingCommand
    {
        Task<CreateBookingModel> Execute(CreateBookingModel model);
    }
}
