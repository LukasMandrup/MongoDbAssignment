using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbAssignment.Models
{
    public class Society
    {
	    [BsonId]
	    public string Id { get; set; }
	    
	    [BsonElement("CVR")]
	    public string CVR { get; set; }
	    
	    [BsonElement("Activity")]
	    public string Activity { get; set; }
        
	    [BsonElement("Address")]
	    public string Address { get; set; }
        
	    [BsonElement("Name")]
	    public string Name { get; set; }

	    [BsonElement("Municipality")]
	    public Municipality Municipality { get; set; }
	    
	    [BsonElement("Chairman")]
	    public Chairman Chairman { get; set; }

	    [BsonElement("SocietyMembers")]
	    public List<SocietyMember> SocietyMembers { get; set; }
        
	    [BsonElement("Bookings")]
	    public List<Booking> Bookings { get; set; }
	    
	    [BsonElement("KeyResponsible")]
	    public KeyResponsible? KeyResponsible { get; set; }
    }
}
