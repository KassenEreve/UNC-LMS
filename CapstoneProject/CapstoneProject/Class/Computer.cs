using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
    public class Computer
    {
        public int id { get; set; }
        public List<SoftwareInventory> softwareInventories { get; set; }
        public List<ComputerLog> computeLogs { get; set; }
        public List<Equipment> pcparts_equipment { get; set; }
    }
}
