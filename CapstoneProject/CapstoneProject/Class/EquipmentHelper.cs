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
                SqlParameter[] param = { new SqlParameter("@lab_id", laboratory_id) };
                var table = dal.ExecuteQuery("GetOtherEquipmentWithCount", param).Tables[0];

                list = new List<Equipment>();

                foreach (DataRow dr in table.AsEnumerable())
                {


                    Equipment equipment = new Equipment()
                    {
                        id = dr.Field<int>("id"),
                        laboratory = new Laboratory() { id = laboratory_id },
                        //computer_id = dr.Field<int>("comp_id"),
                        equipmentType = new EquipmentType() { id = dr.Field<int>("equipmentType_id"),name = dr.Field<string>("name") },
                        count = dr.Field<int>("count")
                        // equipmentHistory = 



                    };
                    list.Add(equipment);
                }
            }

            return (list.Count() > 0) ? list : null;

        }

        public static int GetComputerCount(int lab_id)
        {
            int count = 0;
            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return 0;
                SqlParameter[] param = { new SqlParameter("@lab_id", lab_id) };
                var table = dal.ExecuteQuery("GetComputerCount", param).Tables[0];

              

                foreach (DataRow dr in table.AsEnumerable())
                {

                    count = dr.Field<int>("count");
                   
                }
            }
            return count;
        }

        internal static bool SaveEquipment(Equipment equipment)
        {
            if (equipment==null)
                return false;

            using (DAL dal = new DAL())
            {

                if (!dal.IsConnected) return false;


                SqlParameter[] param = {  new  SqlParameter("@id",  equipment.id),
                                       new  SqlParameter("@lab_id",  equipment.laboratory.id),
                                        new  SqlParameter("@comp_id", (equipment.computer_id==0)?(object)DBNull.Value:equipment.computer_id),
                                         new  SqlParameter("@type_id", equipment.equipmentType.id)



                                       };

                try
                {

                    dal.ExecuteNonQuery("SaveEquipment", param);




                    return true;


                }
                catch (Exception ex)
                {
                    //inspect ex.Message
                    string sd = ex.Message;
                    return false;
                }




            }
        }
    }
}
