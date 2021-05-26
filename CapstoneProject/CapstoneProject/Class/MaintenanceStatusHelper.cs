using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
    public class MaintenanceStatusHelper
    {
        public static List<MaintenanceStatus> GetAllMaintenanceStatus()
        {
            List<MaintenanceStatus> list = null;

            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return null;

                var table = dal.ExecuteQuery("GetAllMaintenanceStatus").Tables[0];

                list = new List<MaintenanceStatus>();

                foreach (DataRow dr in table.AsEnumerable())
                {


                    var status = new MaintenanceStatus()
                    {
                        id = dr.Field<int>("id"),
                        name = dr.Field<string>("name"),
                        //computer_id = dr.Field<int>("comp_id"),

                        description = dr.Field<string>("description"),
                        // equipmentHistory = 
                        color_argb = dr.Field<int>("color_argb")



                    };
                    list.Add(status);
                }
            }

            return (list.Count() > 0) ? list : null;
        }

        internal static bool SaveMaintenanceStatus(MaintenanceStatus saveStatus)
        {
            if (saveStatus == null)
                return false;

            using (DAL dal = new DAL())
            {

                if (!dal.IsConnected) return false;


                SqlParameter[] param = { new  SqlParameter("@id",saveStatus.id),
                                       new  SqlParameter("@name",saveStatus.name),
                                       new  SqlParameter("@description",saveStatus.description),
                                       new  SqlParameter("@color_argb",saveStatus.color_argb)



                                       };

                try
                {

                    dal.ExecuteNonQuery("SaveMaintenanceStatus", param);




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
