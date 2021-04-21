using System.Collections.Generic;

namespace CapstoneProject.Class
{
    public class SoftwareInventory
    {
        public int id { get; set; }
        public Computer computer { get; set; }
        public Software software { get; set; }
        public License license { get; set; }
        public List<SoftwareStatusHistory> softwareHistory { get; set; }
    }
}