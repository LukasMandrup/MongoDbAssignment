
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbAssignment.Models
{
    public class Member
    {
		[BsonId]
		public int Id { get; set; }
    
		[BsonElement("FirstName")]
		public string FirstName { get; set; }
		[BsonElement("LastName")]
		public string LastName { get; set; }

		[BsonElement("Societies")]
		public IList<Society> Societies { get; set; }
		[BsonElement("Bookings")]
		public IList<Booking> Bookings { get; set; }
    }
}
