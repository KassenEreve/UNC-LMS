using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
   public class SoftwareGroupAssignment
    {
        public int id { get; set; }

        public List<SoftwareInventory> softwareInventories { get; set; }
        public SoftwareGroup softwareGroup { get; set; }
        public Computer computer { get; set; }
    }
}
