﻿using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbAssignment.Models
{
    public class Location
    {
	    [BsonId]
	    public int Id { get; set; }
	    
	    [BsonElement("Address")]
	    public string Address { get; set; }
		
	    [BsonElement("Capacity")]
	    public int Capacity { get; set; }
	    
	    [BsonElement("Name")]
	    public string Name { get; set; }
        
	    [BsonElement("AccessKey")]
	    public int AccessCode { get; set; }
	    
	    [BsonElement("Properties")]
	    public string Properties { get; set; }
	    
	    [BsonElement("Purpose")]
	    public string Purpose { get; set; }

	    [BsonElement("KeyResponsible")]
	    public IList<int> KeyResponsibleIds { get; set; }
	    
	    //Reference
	    [BsonElement("Municipality")]
	    public int MunicipalityId { get; set; }
	    
	    //Embedded
	    [BsonElement("KeyId")]
	    public List<int> KeyId { get; set; }
    }
}
