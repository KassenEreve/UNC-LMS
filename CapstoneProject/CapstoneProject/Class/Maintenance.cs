using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
   public  class Maintenance
    {
        public int id { get; set; }
        public Technician technician { get; set; }
        public MaintenanceLevel maintenanceLevel { get; set; }
        public List<MaintenanceStatusHistory> statusHistory { get; set; }
        public DateTime date { get; set; }
    }
}
