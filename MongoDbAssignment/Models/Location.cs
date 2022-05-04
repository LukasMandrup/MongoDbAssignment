using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace Handin2
{
    public class Location
    {
	    [BsonId]
	    public string Id { get; set; }
	    
	    [BsonElement("Address")]
	    public string Address { get; set; }
		
	    [BsonElement("Capacity")]
	    public int Capacity { get; set; }
	    
	    [BsonElement("Name")]
	    public string Name { get; set; }
        
	    [BsonElement("AccessKey")]
	    public int AccessKey { get; set; }
	    
	    [BsonElement("Properties")]
	    public string Properties { get; set; }
	    
	    [BsonElement("Purpose")]
	    public string Purpose { get; set; }
        
	    [BsonElement("Rooms")]
	    public IList<Room> Rooms { get; set; }

	    [BsonElement("Bookings")]
	    public IList<Booking> Bookings { get; set; }
	    
	    [BsonElement("Municipality")]
	    public Municipality Municipality { get; set; }
    }
}
