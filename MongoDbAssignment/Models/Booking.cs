using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbAssignment.Models
{
    public class Booking
    {
	    [BsonId]
        public int Id { get; set; }

	    [BsonElement("StartTime")]
        public DateTime StartTime { get; set; }
	    [BsonElement("EndTime")]
	    public DateTime EndTime { get; set; }
	    [BsonElement("Member")]
	    public int? Member { get; set; }
	    [BsonElement("Society")]
	    public int? Society { get; set; }
	    [BsonElement("Room")]
	    public int? Room { get; set; }
	    [BsonElement("Location")]
	    public int? Location { get; set; }
    }
}
