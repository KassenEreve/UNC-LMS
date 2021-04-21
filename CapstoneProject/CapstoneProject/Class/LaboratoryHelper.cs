using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
    public class LaboratoryHelper
    {
        public static List<Laboratory>  GetAllLaboratories()
        {
            var list = new List<Laboratory>();
            list.Add(new Laboratory());
            list.Add(new Laboratory());
            return list;
        }
    }
}
