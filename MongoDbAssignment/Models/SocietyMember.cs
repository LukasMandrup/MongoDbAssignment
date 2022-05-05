using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace Handin2
{
    public class SocietyMember
    {
	    [BsonId]
	    public int Id { get; set; }
        
	    [BsonElement("Member")]
	    public Member Member { get; set; }
	    [BsonElement("Society")]
	    public Society Society { get; set; }
    }
}
