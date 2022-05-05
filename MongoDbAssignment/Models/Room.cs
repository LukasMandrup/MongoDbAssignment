using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace Handin2
{
    public class Room
    {
	    [BsonId]
	    public int Id { get; set; }

	    [BsonElement("AccessKey")]
	    public int AccessKey { get; set; }

	    [BsonElement("Capacity")]
	    public int Capacity { get; set; }
        
	    [BsonElement("Properties")]
	    public string Properties { get; set; }
        
	    [BsonElement("Name")]
	    public string Name { get; set; }
        
	    [BsonElement("Location")]
	    public Location Location { get; set; }
	    
        [BsonElement("Bookings")]
        public List<Booking> Bookings { get; set; }
    }
}
