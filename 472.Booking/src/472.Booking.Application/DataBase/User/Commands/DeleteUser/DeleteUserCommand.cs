using _472.Booking.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace _472.Booking.Application.DataBase.User.Commands.DeleteUser
{
    public class DeleteUserCommand : IDeleteUserCommand
    {
        private readonly IDataBaseService _dataBaseService;

        public DeleteUserCommand(IDataBaseService dataBaseService)
        {
            _dataBaseService = dataBaseService;
        }

        public async Task<bool> Execute(int UserId)
        {
            var entity = await _dataBaseService.User.FirstOrDefaultAsync(x => x.UserId == UserId);
            if (entity == null)
                return false;

            _dataBaseService.User.Remove(entity);
            await _dataBaseService.SaveAsync();
            return true;
        }
    }
}
