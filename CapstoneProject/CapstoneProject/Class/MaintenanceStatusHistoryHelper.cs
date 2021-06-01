using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
    public class MaintenanceStatusHistoryHelper
    {
        public static List<MaintenanceStatusHistory> GetAllMaintenanceStatusHistory(int maintenance_id)
        {
            List<MaintenanceStatusHistory> list = null;

            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return null;
                SqlParameter[] param = { new SqlParameter("@maintenance_id", maintenance_id) };
                var table = dal.ExecuteQuery("GetAllMaintenanceStatusHistory", param).Tables[0];

                list = new List<MaintenanceStatusHistory>();

                foreach (DataRow dr in table.AsEnumerable())
                {


                    var save = new MaintenanceStatusHistory()
                    {
                        id = dr.Field<int>("id"),
                        maintenance = new Maintenance() { id = maintenance_id },
                        //computer_id = dr.Field<int>("comp_id"),
                        status = new MaintenanceStatus() { id = dr.Field<int>("status_id"),name = dr.Field<string>("name"),description = dr.Field<string>("description"),color_argb = dr.Field<int>("color_argb") },
                        date = dr.Field<DateTime>("date")

                        // equipmentHistory = 



                    };
                    list.Add(save);
                }
            }

            return (list.Count() > 0) ? list : null;
        }
    }
}
