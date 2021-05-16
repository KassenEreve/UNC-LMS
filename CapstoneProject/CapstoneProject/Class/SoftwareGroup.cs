using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
   public class SoftwareGroup
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Software> softwares { get; set; }
    }
}
