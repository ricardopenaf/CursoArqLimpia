using _472.Booking.API;
using _472.Booking.Application;
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

builder.Services.AddControllers();
var app = builder.Build();

//app.MapPost("/testService", async (IGetBookingByTypeQuery service) =>
//{
//    //var model = new CreateBookingModel
//    //{
//    //    RegisterDate = DateTime.Now,
//    //    Code = Guid.NewGuid().ToString(),
//    //    Type = BookingType.Documentation.ToString(),
//    //    UserId = 3,
//    //    CustomerId = 3
//    //};
//    return await service.Execute("Documentation");


//});

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

app.MapControllers();
app.Run();


