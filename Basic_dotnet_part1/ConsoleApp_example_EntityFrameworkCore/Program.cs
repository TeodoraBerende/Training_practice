// See https://aka.ms/new-console-template for more information
using HotelManagement.DataAccessLayer;
using HotelManagement.Entitties;

//Console.WriteLine("Hello, World!");

GetAllHotels();
CreateHotel(); // Add a new Hotel
GetAllHotels();

void CreateHotel()
{
    var hotel = new Hotel
    {
        Name = "Hotel 1",
        IsDeleted = false,
        City = "Timisoara",
        Stars = 5,
        Country = "Romania"
    };

    DataContext _dbContext = new DataContext();

    _dbContext.Hotels.Add(hotel);
    _dbContext.SaveChanges();
}

void GetAllHotels()
{
    DataContext _dbContext = new DataContext();
    
    var hotels = _dbContext.Hotels
        .ToList();

    foreach (var hotel in hotels)
    {
        Console.WriteLine(hotel.Name + " " + hotel.Stars + " " + hotel.City);
    }
}
