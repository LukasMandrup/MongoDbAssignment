using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbAssignment.Models;

public class KeyResponsible
{
	[BsonId]
	public int Id { get; set; }
	
	[BsonElement("Member")]
	public Member? Member { get; set; }

	[BsonElement("Chairman")]
	public Chairman? Chairman { get; set; }
	
	[BsonElement("Society")]
	public Society? Society { get; set; }

	[BsonElement("HomeAddress")]
	public string HomeAddress { get; set; }
	
	[BsonElement("PhoneNumber")]
	public string PhoneNumber { get; set; }

	[BsonElement("PassportNumber")]
	public string PassportNumber { get; set; }

	[BsonElement("Location")]
	public List<int> LocationIds { get; set; }
}
