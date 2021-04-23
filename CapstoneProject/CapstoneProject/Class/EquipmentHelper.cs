using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
   public class EquipmentHelper
    {
        public static List<Equipment> Equipments(int laboratory_id)
        {
            List<Equipment> list = null;

            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return null;
                SqlParameter[] param = { new SqlParameter("@id", laboratory_id) };
                var table = dal.ExecuteQuery("GetAllEquipments", param).Tables[0];

                list = new List<Equipment>();

                foreach (DataRow dr in table.AsEnumerable())
                {


                    Equipment equipment = new Equipment()
                    {
                        id = dr.Field<int>("id"),
                        laboratory = new Laboratory() { id = dr.Field<int>("laboratory_id") },
                        computer_id = dr.Field<int>("comp_id"),
                        equipmentType = EquipmentTypeHelper.getEquipmentType(dr.Field<int>(" equipmentType_id")),
                       // equipmentHistory = 
                       


                    };
                    list.Add(equipment);
                }
            }

            return (list.Count() > 0) ? list : null;

        }
    }
}
