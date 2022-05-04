using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handin2
{
    public class Location
    {
        public string Address { get; set; }
        public int Capacity { get; set; }
        [Key]
        public string Name { get; set; }
        public int AccessKey { get; set; }
        public string Properties { get; set; }
        public string Purpose { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Booking> Bookings { get; set; }
        public Municipality Municipality { get; set; }
        [ForeignKey("Municipality")]
        public string MunicipalityNameFK { get; set; }
    }
}
