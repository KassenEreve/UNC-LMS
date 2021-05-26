using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
    public class CustodianReportedItem
    {
        public int id { get; set; }
        public SoftwareInventory softwareInventory { get; set; }
        public Equipment equipment { get; set; }
        public string issueDescription { get; set; }
        public CustodianReport custodianReport { get; set; }

    }
}
