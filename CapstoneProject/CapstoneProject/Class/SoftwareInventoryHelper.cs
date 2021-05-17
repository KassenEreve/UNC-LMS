using System;
using System.Collections.Generic;
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
    }
}
