using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
    public class MaintenanceHelper
    {
        public static Maintenance GetMaintenance(int maintenance_id)
        {
            Maintenance maintenance = null;

            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return null;
                SqlParameter[] param = { new SqlParameter("@maintenance_id", maintenance_id) };
                var table = dal.ExecuteQuery("GetMaintenance", param).Tables[0];



                foreach (DataRow dr in table.AsEnumerable())
                {


                    maintenance = new Maintenance()
                    {
                        id = dr.Field<int>("id"),
                        technician = new Technician() { id = dr.Field<int>("technician_id"),fname = dr.Field<string>("fname"),mname = dr.Field<string>("mname"),lname = dr.Field<string>("lname") },
                        //computer_id = dr.Field<int>("comp_id"),
                        date = dr.Field<DateTime>("date"),
                        statusHistory = MaintenanceStatusHistoryHelper.GetAllMaintenanceStatusHistory(dr.Field<int>("id")),
                        maintenanceLevel = new MaintenanceLevel() { id = dr.Field<int>("maintenanceLvl_id"),name = dr.Field<string>("level_name"),description = dr.Field<string>("description") }
                        // equipmentHistory = 
                        


                    };

                }
            }

            return maintenance;
        }
    }
}
