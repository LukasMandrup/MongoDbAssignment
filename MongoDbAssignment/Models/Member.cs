using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace Handin2
{
    public class Member
    {
		[BsonId]
		public int Id { get; set; }
    
		[BsonElement("FirstName")]
		public string FirstName { get; set; }
		[BsonElement("LastName")]
		public string LastName { get; set; }
		[BsonElement("MemberId")]
		public int MemberId { get; set; }

		[BsonElement("SocietyMembers")]
		public List<SocietyMember> SocietyMembers { get; set; }
		[BsonElement("Bookings")]
		public List<Booking> Bookings { get; set; }
    }
}
