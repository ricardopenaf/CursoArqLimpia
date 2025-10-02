using _472.Booking.Application.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace _472.Booking.Application.DataBase.User.Queries.GetUserById
{
    public class GetUserByIdQuery : IGetUserByIdQuery
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;

        public GetUserByIdQuery(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }

        public async Task<GetUserByIdModel?> Execute(int userId)
        {
            var entity = await _dataBaseService.User.FirstOrDefaultAsync(x => x.UserId == userId);
            if (entity == null)
                return null;

            var model = _mapper.Map<GetUserByIdModel>(entity);
            return model;
        }
    }
}
