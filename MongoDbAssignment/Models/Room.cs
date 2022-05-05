﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbAssignment.Models
{
    public class Room
    {
	    [BsonId]
	    [BsonRepresentation(BsonType.ObjectId)]
	    public string Id { get; set; }

	    [BsonElement("AccessKey")]
	    public int AccessKey { get; set; }

	    [BsonElement("Capacity")]
	    public int Capacity { get; set; }
        
	    [BsonElement("Properties")]
	    public string Properties { get; set; }
        
	    [BsonElement("Name")]
	    public string Name { get; set; }
        
	    [BsonElement("Location")]
	    public string Location { get; set; }
    }
}
