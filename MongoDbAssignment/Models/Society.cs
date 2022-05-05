using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbAssignment.Models
{
    public class Society
    {
	    [BsonId]
	    public int Id { get; set; }
	    
	    [BsonElement("CVR")]
	    public string CVR { get; set; }
	    
	    [BsonElement("Activity")]
	    public string Activity { get; set; }
        
	    [BsonElement("Address")]
	    public string Address { get; set; }
        
	    [BsonElement("Name")]
	    public string Name { get; set; }

	    [BsonElement("Municipality")]
	    public int Municipality { get; set; }
	    
	    [BsonElement("Chairman")]
	    public Chairman Chairman { get; set; }

	    [BsonElement("Members")]
	    public IList<int> Members { get; set; }

	    [BsonElement("KeyResponsible")]
	    public int? KeyResponsible { get; set; }

	    [BsonElement("ChairmanId")]
	    public int ChairmanId { get; set; }
    }
}
