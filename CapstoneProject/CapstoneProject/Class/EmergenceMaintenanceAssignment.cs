using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
   public class EmergenceMaintenanceAssignment
    {
        public int id { get; set; }
        public CustodianReport custodianReport { get; set; }
        public Maintenance maintenance { get; set; }
    }
}
