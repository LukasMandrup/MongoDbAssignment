using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbAssignment.Models;

public class Key
{
	[BsonId]
	public string Id { get; set; }
	
	[BsonElement("PickUpLocation")]
	public string PickUpLocation { get; set; }
	[BsonElement("Location")]
	public Location? Location { get; set; }
}
