﻿using _472.Booking.Application.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace _472.Booking.Application.DataBase.User.Queries.GetAllUser
{
    public class GetAllUserQuery: IGetAllUserQuery
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;
        public GetAllUserQuery(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }

        public async Task<List<GetAllUserModel>> Execute()
        {
            var entity = await _dataBaseService.User.ToListAsync();
            return _mapper.Map<List<GetAllUserModel>>(entity);
        }
    }
}
