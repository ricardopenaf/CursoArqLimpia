using _472.Booking.Application.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace _472.Booking.Application.DataBase.Customer.Queries.GetCustoerGetId
{
    public class GetCustomerByIdQuery: IGetCustomerByIdQuery
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;
        public GetCustomerByIdQuery(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }
        public async Task<GetCustomerByIdModel> Execute(int customerId)
        {
            var entity = await _dataBaseService.Customer.FirstOrDefaultAsync(c => c.CustomerId == customerId);
            var result = _mapper.Map<GetCustomerByIdModel>(entity);
            return result;
        }
    }
}
