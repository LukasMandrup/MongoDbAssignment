using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handin2
{
    public class Chairman
    {
        public string PersonalInformation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Key]
        public string CPR { get; set; }

        public string Address { get; set; }
        public List<Society> Societies { get; set; }
    }
}
