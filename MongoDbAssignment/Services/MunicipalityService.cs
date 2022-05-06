﻿using System.Collections.Immutable;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDbAssignment.Models;

namespace MongoDbAssignment.Services;

public class MunicipalityService
{
    
    private readonly string connectionString = "mongodb://localhost:27017";
    private readonly string municipalityDb = "MunicipalityDb";
    
    private readonly IMongoDatabase _database;
    
    private readonly IMongoCollection<Booking> _bookings;
    private readonly IMongoCollection<Location> _locations;
    private readonly IMongoCollection<Member> _members;
    private readonly IMongoCollection<Municipality> _municipalities;
    private readonly IMongoCollection<Society> _societies;
    private readonly IMongoCollection<KeyResponsible> _keyResponsible;

    public MunicipalityService()
    {
        var client = new MongoClient(connectionString);
        _database = client.GetDatabase(municipalityDb);

        DropDatabase();

        _bookings = _database.GetCollection<Booking>("Bookings");
        _locations = _database.GetCollection<Location>("Locations");
        _members = _database.GetCollection<Member>("Members");
        _municipalities = _database.GetCollection<Municipality>("Municipalities");
        _societies = _database.GetCollection<Society>("Societies");
        _keyResponsible = _database.GetCollection<KeyResponsible>("KeyResponsible");
    }

    private void DropDatabase()
    {
	    Console.WriteLine("Dropping database...\n");

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

		var key1 = new Location.Key
		{
			PickUpLocation = "Samsø"
		};

		var key2 = new Location.Key
		{
			PickUpLocation = "Anholt"
		};
		
		var auditorium = new Location.Room
		{
			AccessKey = 1283641,
			Capacity = 150,
			Properties = "tavler, projektor, microfon",
			Name = "Auditorium"
		};

		var katrinebjerg = new Location.Room
		{
			AccessKey = 12823461,
			Capacity = 30,
			Properties = "kaffemaskine",
			Name = "Kontor"
		};

		Console.WriteLine("Inserting Location");
		var au = new Location
		{
			Name = "Aarhus Universitet",
			Capacity = 50000,
			AccessCode = 8102403,
			Properties = "indedørs",
			Purpose = "Undervisning, Konfererencer",
			Municipality = aarhus.Id,
			Address = "Clematisvænget 92",
			Keys = new List<Location.Key> { key1 },
			Rooms = new List<Location.Room> { auditorium }
		};

		var fodboldBane = new Location
		{
			Name = "Aarhus Fodboldbane",
			Capacity = 500,
			AccessCode = 1238581,
			Properties = "udendørs, fodboldmål, fodbolde",
			Purpose = "Fodbold, Græsplæne",
			Municipality = aarhus.Id,
			Address = "Hulemosevej 67",
			Keys = new List<Location.Key> { key2 },
			Rooms = new List<Location.Room> { katrinebjerg }
		};

		_locations.InsertMany(new List<Location> { au, fodboldBane });

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

		Console.WriteLine("\nDone inserting");
    }
    
    
    public void QueryMunicipalities(string municipalityName)
    {
	    Console.WriteLine("\nQuerying municipalities...\n");
	    
	    var municipalityFilter = Builders<Municipality>.Filter.Eq("Name", municipalityName);
	    var municipality = _municipalities.Find(municipalityFilter).FirstOrDefault();
	    
	    if (municipality == null)
	    {
		    Console.WriteLine($"Municipality {municipalityName} not found");
		    return;
	    }
	    
	    var locationFilter = Builders<Location>.Filter.Eq("Municipality", municipality.Id);
	    var locationsInMunicipality = _locations.Find(locationFilter).ToList();

	    if (!locationsInMunicipality.Any())
	    {
		    Console.WriteLine($"No locations found in {municipalityName}");
		    return;
	    }
	    
	    locationsInMunicipality.ForEach(l => l.WriteRoomAddresses());
    }

    public void QuerySocieties(string activity)
    {
	    Console.WriteLine("\nQuerying societies...\n");

	    var societyFilter = Builders<Society>.Filter.Eq("Activity", activity);
	    var societies = _societies.Find(societyFilter).ToList();
	    
	    if (societies == null)
	    {
		    Console.WriteLine($"Municipality {societies} not found");
		    return;
	    }
	    
	    societies.ForEach(l => l.WriteSociety());
    }

    public void QueryKeyResponsible(KeyResponsible kr)
    {
	    
    }
}