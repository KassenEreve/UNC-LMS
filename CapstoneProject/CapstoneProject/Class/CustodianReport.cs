using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
   public class CustodianReport
    {
        public int id { get; set; }

        public Custodian custodian;
        public List<CustodianReportedItem> custodianReportedItems { get; set; }

        public DateTime date { get; set; }

        public Laboratory laboratory { get; set; }
       // public Laboratory laboratory { get { return CustodianReportHelper.GetLaboratory(this); } }

    }
}
