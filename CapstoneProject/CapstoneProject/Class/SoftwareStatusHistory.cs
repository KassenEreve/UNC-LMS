using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
    public class SoftwareStatusHistory
    {
        public int id { get; set; }
        public SoftwareInventory softwareInventory{ get; set; }
        public Status status { get; set; }
    }
}
