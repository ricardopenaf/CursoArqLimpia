using _472.Booking.Application.Interfaces;
using AutoMapper;

namespace _472.Booking.Application.DataBase.Customer.Queries.GetAllCustomer
{
    public class GetAllCustomerQuery: IGetAllCustomerQuery
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;

        public GetAllCustomerQuery(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }

        public async Task<List<GetAllCustomerModel>> Execute()
        {
            var entity = _dataBaseService.Customer.ToList();
            var result = _mapper.Map<List<GetAllCustomerModel>>(entity);
            return result;
        }
    }
}
