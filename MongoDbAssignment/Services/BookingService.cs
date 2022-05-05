using MongoDB.Driver;
using MongoDbAssignment.Models;

namespace MongoDbAssignment.Services;

public class MunicipalityService
{
    
    private readonly string connectionString = "mongodb://localhost:27017";
    private readonly string municipalityDb = "MunicipalityDb";
    private readonly IMongoCollection<Booking> _bookings;
    private readonly IMongoCollection<Chairman> _chairmen;
    private readonly IMongoCollection<Location> _locations;
    private readonly IMongoCollection<Member> _members;
    private readonly IMongoCollection<Municipality> _municipalities;
    private readonly IMongoCollection<Room> _rooms;
    private readonly IMongoCollection<Society> _societies;

    public MunicipalityService()
    {
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase(municipalityDb);
        _bookings = database.GetCollection<Booking>("Bookings");
        _chairmen = database.GetCollection<Chairman>("Chairmen");
        _locations = database.GetCollection<Location>("Locations");
        _members = database.GetCollection<Member>("Members");
        _municipalities = database.GetCollection<Municipality>("Municipalities");
        _rooms = database.GetCollection<Room>("Rooms");
        _societies = database.GetCollection<Society>("Societies");
    }
    
    
}