using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
    public class SoftwareInventoryHelper
    {
        public static bool  Save(SoftwareInventory inventory,SoftwareGroupAssignment assignment)
        {
            if (inventory == null||assignment==null)
                return false;

            using (DAL dal = new DAL())
            {

                if (!dal.IsConnected) return false;


                SqlParameter[] param = { new  SqlParameter("@software_id",inventory.software.id),
                                       new  SqlParameter("@groupAssignment_id",  assignment.id)




                                       };

                try
                {

                    dal.ExecuteNonQuery("SaveSoftwareInventory", param);




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

        internal static SoftwareInventory GetSoftwareInventory(int softwareInv_id)
        {
            SoftwareInventory inventory = null;
            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return null;

                SqlParameter[] param = { new SqlParameter("@id", softwareInv_id) };
                var table = dal.ExecuteQuery("GetSoftwareInventory", param).Tables[0];

                foreach (DataRow dr in table.AsEnumerable())
                {


                   inventory = new SoftwareInventory()
                    {
                        id = dr.Field<int>("id"),
                       computer =new Computer() { id = dr.Field<int>("computer_id") ,pc_num = dr.Field<string>("pc_num") },
                        software = new Software() { id = dr.Field<int>("software_id"), name = dr.Field<string>("name") }
                       
                    };


                }

                return inventory;
            }
        }

        internal static Laboratory GetLaboaratory(int softwareInv_id)
        {
            return null;
        }
    }
}
