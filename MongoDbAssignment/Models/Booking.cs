using System.ComponentModel.DataAnnotations.Schema;
using MongoDB.Bson.Serialization.Attributes;

namespace Handin2
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
	    public Member? Member { get; set; }
	    [BsonElement("Society")]
	    public Society? Society { get; set; }
	    [BsonElement("Room")]
	    public Room? Room { get; set; }
	    [BsonElement("Location")]
	    public Location? Location { get; set; }
    }
}
