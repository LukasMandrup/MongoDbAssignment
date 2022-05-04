using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Handin2
{
    public class Booking
    {
        public int Id { get; set; }
        [NotMapped]
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }
        public Member Member { get; set; }
        public int MemberId { get; set; }
        public Society Society { get; set; }
        [ForeignKey("Society")]
        public string CVR { get; set; }
        public Room Room { get; set; }
        public int RoomId { get; set; }
        public Location Location { get; set; }
        [ForeignKey("Location")]
        public string LocationNameFK { get; set; }

    }
}
