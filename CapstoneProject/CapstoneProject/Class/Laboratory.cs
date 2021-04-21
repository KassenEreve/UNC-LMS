using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
    public class Laboratory
    {
        public int id { get; set; }
        public string roomNum { get; set; }

        public List<Equipment> equipments { get; set; }
    }
}
