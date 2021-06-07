using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
    public class Attendance
    {
        public TimeSpan fromTime { get; set; }
        public TimeSpan toTime { get; set; }
        public ComputerLog log { get; set; }
        public bool isLate { get; set; }
    }
}
