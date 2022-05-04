using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handin2
{
    public class Room
    {
        public int RoomId { get; set; }
        public int AccessKey { get; set; }
        public int Capacity { get; set; }
        public string Properties { get; set; }
        public string Name { get; set; }
        public Location Location { get; set; }
        [ForeignKey("Location")]
        public string LocationNameFK { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}
