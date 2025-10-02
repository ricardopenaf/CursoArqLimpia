namespace _472.Booking.Application.DataBase.Customer.Queries.GetCustomerByDocumentNumber
{
    public interface IGetCustomerByDocumentNumberQuery
    {
        Task<GetCustomerByDocumentNumberModel> Execute(string documentNumber);
    }
}
