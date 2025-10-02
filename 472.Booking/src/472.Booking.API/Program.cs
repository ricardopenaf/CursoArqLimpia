using _472.Booking.API;
using _472.Booking.Application;
using _472.Booking.Application.DataBase.Customer.Commands.CreateCustomer;
using _472.Booking.Application.DataBase.Customer.Commands.DeleteCustomer;
using _472.Booking.Application.DataBase.Customer.Commands.UpdateCustomer;
using _472.Booking.Application.DataBase.Customer.Queries.GetAllCustomer;
using _472.Booking.Application.DataBase.Customer.Queries.GetCustoerGetId;
using _472.Booking.Application.DataBase.Customer.Queries.GetCustomerByDocumentNumber;
using _472.Booking.Application.DataBase.User.Commands.CreateUser;
using _472.Booking.Application.DataBase.User.Commands.DeleteUser;
using _472.Booking.Application.DataBase.User.Commands.UpdateUser;
using _472.Booking.Application.DataBase.User.Commands.UpdateUserPassword;
using _472.Booking.Application.DataBase.User.Queries.GetAllUser;
using _472.Booking.Application.DataBase.User.Queries.GetUserById;
using _472.Booking.Application.DataBase.User.Queries.GetUserByUserNameAndPassword;
using _472.Booking.Common;
using _472.Booking.External;
using _472.Booking.Persistence;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddWebApi()
    .AddCommon()
    .AddApplication()
    .AddExternal(builder.Configuration)
    .AddPersistence(builder.Configuration);

var app = builder.Build();

app.MapPost("/testService", async (IGetCustomerByDocumentNumberQuery service) =>
{
    return await service.Execute("12345");


});

// Configure the HTTP request pipeline.

//app.MapPost("/createTest", async (IDataBaseService _databaseService) => 
//{
//    var user = new _472.Booking.Domain.Enetities.User.UserEntity
//    {
//        FirstName = "Ricardo",
//        LastName = "Pena",
//        UserName = "Richy",
//        Password = "123456"
//    };
//    await _databaseService.User.AddAsync(user);
//    await _databaseService.SaveAsync();
//    return Results.Ok("User created");
//});

//app.MapGet("/testGet", async (IDataBaseService _databaseService) =>
//{
//    var result = await _databaseService.User.ToListAsync();
//    return Results.Ok(result);
//});


app.Run();


