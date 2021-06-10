using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
    public class MaintenanceStatusHistory
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public Maintenance maintenance { get; set; }
        public MaintenanceStatus status { get; set; }

        public string description { get; set; }
    }
}
