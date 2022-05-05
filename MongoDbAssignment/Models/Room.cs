using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbAssignment.Models
{
    public class Room
    {
	    [BsonId]
	    public int Id { get; set; }

	    [BsonElement("AccessKey")]
	    public int AccessKey { get; set; }

	    [BsonElement("Capacity")]
	    public int Capacity { get; set; }
        
	    [BsonElement("Properties")]
	    public string Properties { get; set; }
        
	    [BsonElement("Name")]
	    public string Name { get; set; }
        
	    [BsonElement("Location")]
	    public Location Location { get; set; }
    }
}
