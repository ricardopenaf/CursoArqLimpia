﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _472.Booking.Application.DataBase.User.Commands.UpdateUser
{
    public interface IUpdateUserCommand
    {
        Task<UpdateUserModel> Execute(UpdateUserModel model);
    }
}
