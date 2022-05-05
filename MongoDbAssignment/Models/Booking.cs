using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbAssignment.Models
{
    public class Booking
    {
	    [BsonId]
	    [BsonRepresentation(BsonType.ObjectId)]
	    public string Id { get; set; }

	    [BsonElement("StartTime")]
        public DateTime StartTime { get; set; }
	    [BsonElement("EndTime")]
	    public DateTime EndTime { get; set; }
	    [BsonElement("Member")]
	    public string? Member { get; set; }
	    [BsonElement("Society")]
	    public string? Society { get; set; }
	    [BsonElement("Room")]
	    public string? Room { get; set; }
	    [BsonElement("Location")]
	    public string? Location { get; set; }
    }
}
