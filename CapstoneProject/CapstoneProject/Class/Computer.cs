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
        public string pc_num { get; set; }
        public SoftwareGroupAssignment softwareGroupAssignment { get; set; }
        public List<ComputerLog> computeLogs { get; set; }
        public List<Equipment> pcparts_equipment { get; set; }

        public Laboratory laboratory { get; set; }

        public PCSpecs specifcation { get; set; }

        public SoftwareGroup softwareGroup { get; set; }
    }
}
