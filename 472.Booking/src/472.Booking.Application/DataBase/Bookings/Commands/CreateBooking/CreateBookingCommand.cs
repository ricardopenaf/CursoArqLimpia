﻿using _472.Booking.Application.Interfaces;
using _472.Booking.Domain.Enetities.Booking;
using AutoMapper;

namespace _472.Booking.Application.DataBase.Bookings.Commands.CreateBooking
{
    public class CreateBookingCommand: ICreateBookingCommand
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;

        public CreateBookingCommand(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }

        public async Task<CreateBookingModel> Execute(CreateBookingModel model)
        {
            var entity = _mapper.Map<BookingEntity>(model);
            await _dataBaseService.Booking.AddAsync(entity);
            await _dataBaseService.SaveAsync();
            return model;
        }
    }
}
