using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handin2
{
    public class SocietyMember
    {
        public int SocietyMemberId { get; set; }
        public Member Member { get; set; }
        public int MemberId { get; set; }
        public Society Society { get; set; }
        [ForeignKey("Society")]
        public string CVR { get; set; }
    }
}
