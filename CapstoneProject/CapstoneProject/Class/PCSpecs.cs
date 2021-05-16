using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
    public class PCSpecs
    {
        public int id { get; set; }
        public string code { get; set; }
        public  string processor { get; set; }
        public string motherboard { get; set; }
        public string memory { get; set; }

        public string video { get; set; }

        public string hdd { get; set; }

        public string casePsu { get; set; }
        public string keyboardMouse { get; set; }
        public string monitor { get; set; }

        public string optical { get; set; }
    }
}
