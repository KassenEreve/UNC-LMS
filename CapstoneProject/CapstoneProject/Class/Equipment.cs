using System.Collections.Generic;

namespace CapstoneProject.Class
{
    public class Equipment
    {
        public int id { get; set; }
        public Laboratory laboratory { get; set; }
        public Computer computer { get; set; }

        public EquipmentType equipmentType { get; set; }
        public List<EquipmentStatusHistory> equipmentHistory { get; set; }
    }
}