using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handin2
{
    public class Municipality
    {
        [Key]
        public string Name { get; set; }

        public List<Location> Locations { get; set; }
        public List<Society> Societies { get; set; }
    }
}
