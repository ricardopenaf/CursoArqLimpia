﻿using _472.Booking.Application.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace _472.Booking.Application.DataBase.User.Queries.GetUserByUserNameAndPassword
{
    public class GetUserByUserNameAndPasswordQuery: IGetUserByUserNameAndPasswordQuery
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;

        public GetUserByUserNameAndPasswordQuery(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }

        public async Task<GetUserByUserNameAndPasswordModel?> Execute(string userName, string password)
        {
            var entity = await _dataBaseService.User
                .FirstOrDefaultAsync(x => x.UserName == userName && x.Password == password);

            if (entity == null)
                return null;

            var model = _mapper.Map<GetUserByUserNameAndPasswordModel>(entity);
            return model;
        }
    }
}
