using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
    public class Custodian
    {
        public int id { get; set; }
        public string studentNum { get; set; }
        public string fname { get; set; }
        public string mname { get; set; }
        public string lname { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public DateTime birthDate { get; set; }
        public string password { get; set; }

        public string fullName { get { return lname + ", " + fname + " " + mname[0]; } }
    }
}
