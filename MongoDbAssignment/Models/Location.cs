using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbAssignment.Models
{
    public class Location
    {
	    [BsonId]
	    [BsonRepresentation(BsonType.ObjectId)]
	    public string Id { get; set; }
	    
	    [BsonElement("Address")]
	    public string Address { get; set; }
		
	    [BsonElement("Capacity")]
	    public int Capacity { get; set; }
	    
	    [BsonElement("Name")]
	    public string Name { get; set; }
        
	    [BsonElement("AccessCode")]
	    public int? AccessCode { get; set; }
	    
	    [BsonElement("Properties")]
	    public List<string> Properties { get; set; }
	    
	    [BsonElement("Purpose")]
	    public string Purpose { get; set; }
	    
	    //Reference
	    [BsonElement("Municipality")]
	    public string Municipality { get; set; }
	    
	    //Embedded
	    [BsonElement("Keys")]
	    public List<Key> Keys { get; set; }
	    
	    [BsonElement("Rooms")]
	    public List<Room> Rooms { get; set; }

	    public void WriteRoomAddresses()
	    {
		    Rooms.ForEach(r => Console.WriteLine($"{r.Name} at address {Address}"));
	    }
	    
	    public string GetAccessInfo()
	    {
		    return $"{Name} has " +
		           (AccessCode == null ? "access code" : "keys")
		           + $" {AccessCode.ToString() ?? string.Join(", ", Keys)}";
	    }
    }
    
    public class Room
    {
	    [BsonId]
	    [BsonRepresentation(BsonType.ObjectId)]
	    public string Id { get; set; }

	    [BsonElement("AccessKey")]
	    public int AccessKey { get; set; }

	    [BsonElement("Capacity")]
	    public int Capacity { get; set; }
        
	    [BsonElement("Properties")]
	    public string Properties { get; set; }
        
	    [BsonElement("Name")]
	    public string Name { get; set; }
    }
	    
    public class Key
    {
	    [BsonId]
	    [BsonRepresentation(BsonType.ObjectId)]
	    public string Id { get; set; }
	
	    [BsonElement("PickUpLocation")]
	    public string PickUpLocation { get; set; }

	    public override string ToString()
	    {
		    return $"Id: {Id} Pick-up Location: {PickUpLocation}";
	    }
    }
}
