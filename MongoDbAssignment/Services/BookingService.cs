using MongoDB.Driver;
using MongoDbAssignment.Models;

namespace MongoDbAssignment.Services;

public class BookingService
{
    
    private readonly string connectionString = "mongodb://localhost:27017";
    private readonly string municipalityDb = "MunicipalityDb";
    private readonly IMongoCollection<Booking> _bookings;
    private readonly string collection = "Bookings";

    public BookingService()
    {
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase(municipalityDb);
        _bookings = database.GetCollection<Booking>(collection);
    }
}