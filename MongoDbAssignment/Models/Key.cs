using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbAssignment.Models;

public class Key
{
	[BsonId]
	[BsonRepresentation(BsonType.ObjectId)]
	public string Id { get; set; }
	
	[BsonElement("PickUpLocation")]
	public string PickUpLocation { get; set; }
}
