using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbAssignment.Models
{
    public class Chairman
    {
	    [BsonId]
	    [BsonRepresentation(BsonType.ObjectId)]
	    public string Id { get; set; }
	    
	    [BsonElement("PersonalInformation")]
        public string PersonalInformation { get; set; }
	    
	    [BsonElement("FirstName")]
	    public string FirstName { get; set; }
	    
	    [BsonElement("LastName")]
	    public string LastName { get; set; }
	    
	    [BsonElement("CPR")]
	    public string CPR { get; set; }

	    [BsonElement("Address")]
	    public string Address { get; set; }
	    
    }
}
