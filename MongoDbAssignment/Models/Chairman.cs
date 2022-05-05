using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbAssignment.Models
{
    public class Chairman
    {
	    [BsonId]
	    public int Id { get; set; }
	    
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
