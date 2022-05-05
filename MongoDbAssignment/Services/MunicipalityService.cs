using MongoDB.Driver;
using MongoDbAssignment.Models;

namespace MongoDbAssignment.Services;

public class MunicipalityService
{
    
    private readonly string connectionString = "mongodb://localhost:27017";
    private readonly string municipalityDb = "MunicipalityDb";
    
    private readonly IMongoDatabase _database;
    
    private readonly IMongoCollection<Booking> _bookings;
    private readonly IMongoCollection<Chairman> _chairmen;
    private readonly IMongoCollection<Location> _locations;
    private readonly IMongoCollection<Member> _members;
    private readonly IMongoCollection<Municipality> _municipalities;
    private readonly IMongoCollection<Room> _rooms;
    private readonly IMongoCollection<Society> _societies;
    private readonly IMongoCollection<KeyResponsible> _keyResponsible;

    public MunicipalityService()
    {
        var client = new MongoClient(connectionString);
        _database = client.GetDatabase(municipalityDb);

        DropDatabase();

        _bookings = _database.GetCollection<Booking>("Bookings");
        _chairmen = _database.GetCollection<Chairman>("Chairmen");
        _locations = _database.GetCollection<Location>("Locations");
        _members = _database.GetCollection<Member>("Members");
        _municipalities = _database.GetCollection<Municipality>("Municipalities");
        _rooms = _database.GetCollection<Room>("Rooms");
        _societies = _database.GetCollection<Society>("Societies");
        _keyResponsible = _database.GetCollection<KeyResponsible>("KeyResponsible");
    }

    private void DropDatabase()
    {
	    _database.DropCollection("Bookings");
	    _database.DropCollection("Chairmen");
	    _database.DropCollection("Locations");
	    _database.DropCollection("Members");
	    _database.DropCollection("Municipalities");
	    _database.DropCollection("Rooms");
	    _database.DropCollection("Societies");
	    _database.DropCollection("KeyResponsible");
    }

    public void InsertDummyData()
    { 
	    Console.WriteLine("Inserting Municipalities");
		var aarhus = new Municipality
		{
			Name = "Aarhus"
		};
		_municipalities.InsertOne(aarhus);

		Console.WriteLine("Inserting chairmen");
		var lone = new Chairman
		{
			FirstName = "Lone",
			LastName = "Lonsen",
			Address = "123 Main Street",
			CPR = "112341242351",
			PersonalInformation = "lone@lonsen.com"
		};
		var kevin = new Chairman
		{
			FirstName = "Kévina",
			LastName = "Drakes",
			Address = "159 Rieder Circle",
			CPR = "4410893880",
			PersonalInformation = "cdrakes0@plala.or.jp"
		};

		var key1 = new Key
		{
			PickUpLocation = "Samsø"
		};

		var key2 = new Key
		{
			PickUpLocation = "Anholt"
		};

		Console.WriteLine("Inserting Location");
		var au = new Location
		{
			Name = "Aarhus Universitet",
			Capacity = 50000,
			AccessCode = 8102403,
			Properties = "indedørs",
			Purpose = "Undervisning, Konfererencer",
			MunicipalityId = aarhus.Id,
			Address = "Clematisvænget 92",
			KeyId = new List<string> { key1.Id }
		};

		var fodboldBane = new Location
		{
			Name = "Aarhus Fodboldbane",
			Capacity = 500,
			AccessCode = 1238581,
			Properties = "udendørs, fodboldmål, fodbolde",
			Purpose = "Fodbold, Græsplæne",
			MunicipalityId = aarhus.Id,
			Address = "Hulemosevej 67",
			KeyId = new List<string> { key2.Id }
		};

		_locations.InsertMany(new List<Location> { au, fodboldBane });
		
		Console.WriteLine("Inserting Rooms");
		var auditorium = new Room
		{
			AccessKey = 1283641,
			Capacity = 150,
			Properties = "tavler, projektor, microfon",
			Name = "Auditorium",
			Location = au.Id
		};

		var katrinebjerg = new Room
		{
			AccessKey = 12823461,
			Capacity = 30,
			Properties = "kaffemaskine",
			Name = "Kontor",
			Location = fodboldBane.Id
		};

		_rooms.InsertOne(auditorium);
		_rooms.InsertOne(katrinebjerg);

		Console.WriteLine("Inserting Members");
		var lionel = new Member
		{
			FirstName = "Lionel",
			LastName = "Hernandez"
		};

		var rachel = new Member
		{
			FirstName = "Rachel",
			LastName = "Moses"
		};

		_members.InsertOne(lionel);
		_members.InsertOne(rachel);
		
		Console.WriteLine("Inserting Societies");
		var fodbold = new Society
		{
			CVR = "4410893880",
			Activity = "Fodbold",
			Address = "Vejlebæksvej 25",
			Chairman = lone,
			Name = "Vejlebæk FC",
			Municipality = aarhus.Id,
			Members = new List<string> { lionel.Id, rachel.Id },
		};

		var kommunistPartiet = new Society
		{
			CVR = "8925973971",
			Activity = "Konferrence",
			Address = "Mellemvej 58",
			Chairman = kevin,
			Name = "Kommunist Partiet",
			Municipality = aarhus.Id,
			Members = new List<string> { lionel.Id }
		};

		_societies.InsertOne(fodbold);
		_societies.InsertOne(kommunistPartiet);

		Console.WriteLine("Inserting Bookings");
		var b1 = new Booking
		{
			StartTime = DateTime.Now,
			EndTime = DateTime.Now.Add(TimeSpan.FromHours(2)),
			Member = lionel.Id,
			Room = katrinebjerg.Id
		};

		var b2 = new Booking
		{
			StartTime = DateTime.Now.Add(TimeSpan.FromHours(2)),
			EndTime = DateTime.Now.Add(TimeSpan.FromHours(4)),
			Society = fodbold.Id,
			Location = fodboldBane.Id
		};

		_bookings.InsertOne(b1);
		_bookings.InsertOne(b2);

		Console.WriteLine("Inserting Key Responsible");
		var kr1 = new KeyResponsible
		{
			Member = lionel.Id,
			Society = fodbold.Id,
			HomeAddress = "Messivej 10",
			PhoneNumber = "1010101001",
			PassportNumber = "0101010101-01"
		};

		_keyResponsible.InsertOne(kr1);

		Console.WriteLine("Done inserting");
    }
    
}