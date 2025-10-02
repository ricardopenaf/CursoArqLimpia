namespace _472.Booking.Application.DataBase.Customer.Queries.GetCustoerGetId
{
    public interface IGetCustomerByIdQuery
    {
        Task<GetCustomerByIdModel> Execute(int customerId);
    }
}
