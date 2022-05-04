using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handin2
{
    public class Society
    {
        [Key]
        public string CVR { get; set; }

        public string Activity { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public Municipality Municipality { get; set; }
        [ForeignKey("Municipality")]
        public string MunicipalityNameFK { get; set; }
        public Chairman Chairman { get; set; }
        [ForeignKey("Chairman")]
        public string ChairmanCPRFK { get; set; }
        public List<SocietyMember> SocietyMembers { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}
