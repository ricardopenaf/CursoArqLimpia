namespace _472.Booking.Application.DataBase.Customer.Commands.DeleteCustomer
{
    public interface IDeleteCustomerCommad
    {
        Task<bool> Execute(int customerId);
    }
}
