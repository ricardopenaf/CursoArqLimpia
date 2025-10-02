using _472.Booking.Application.Interfaces;
using _472.Booking.Domain.Enetities.Customer;
using AutoMapper;

namespace _472.Booking.Application.DataBase.Customer.Commands.UpdateCustomer
{
    public class UpdateCustomerCommand : IUpdateCustomerCommand
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;
        public UpdateCustomerCommand(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }
        public async Task<UpdateCustomerModel> Execute(UpdateCustomerModel model)
        {
            var entity = _mapper.Map<CustomerEntity>(model);
            _dataBaseService.Customer.Update(entity);
            var result = await _dataBaseService.SaveAsync();
            return model;
        }
    }
}
