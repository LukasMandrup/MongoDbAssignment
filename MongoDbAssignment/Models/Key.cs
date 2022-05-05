using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbAssignment.Models;

public class Key
{
	[BsonId]
	public int Id { get; set; }
	
	[BsonElement("PickUpLocation")]
	public string PickUpLocation { get; set; }
}
