using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handin2
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MemberId { get; set; }
        public List<SocietyMember> SocietyMembers { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}
