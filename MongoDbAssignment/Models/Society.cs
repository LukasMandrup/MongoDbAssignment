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
    }
}
