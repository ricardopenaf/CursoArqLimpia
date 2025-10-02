using _472.Booking.Application.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace _472.Booking.Application.DataBase.Customer.Commands.DeleteCustomer
{
    public class DeleteCustomerCommad : IDeleteCustomerCommad
    {
        private readonly IDataBaseService _dataBaseService;

        public DeleteCustomerCommad(IDataBaseService dataBaseService)
        {
            _dataBaseService = dataBaseService;
        }

        public async Task<bool> Execute(int customerId)
        {
            var entity = await _dataBaseService.Customer.FirstOrDefaultAsync(c => c.CustomerId == customerId);
            if (entity == null)
                return  false;

            _dataBaseService.Customer.Remove(entity);
           return await _dataBaseService.SaveAsync();
        }
    }
}
