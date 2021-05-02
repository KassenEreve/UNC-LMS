using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
   public  class PCSpecsHelper
    {

        public static List<PCSpecs> GetAllPCSpecs()
        {
            List<PCSpecs> list = null;

            list = new List<PCSpecs>();
            list.Add(new PCSpecs() { id = 0, processor = "i5-7200", memory = "memoryTest", motherboard = "testMotherboard", video = "videeoo" });
            return list;
        }
    }
}
