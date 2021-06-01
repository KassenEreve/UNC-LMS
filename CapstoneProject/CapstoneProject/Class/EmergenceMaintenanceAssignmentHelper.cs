using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
    public class EmergenceMaintenanceAssignmentHelper
    {
      public static EmergenceMaintenanceAssignment GetEmergencyMaintenanceAssignment(int assignmentID)
      {
            EmergenceMaintenanceAssignment assignment = null;

            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return null;
                SqlParameter[] param = { new SqlParameter("@assignmentID", assignmentID) };
                var table = dal.ExecuteQuery("GetEmergencyMaintenanceAssignment", param).Tables[0];

            

                foreach (DataRow dr in table.AsEnumerable())
                {

                    
                    assignment = new EmergenceMaintenanceAssignment()
                    {
                        id = dr.Field<int>("id"),
                        custodianReport = new CustodianReport() { id = dr.Field<int>("custodianReport_id") },
                        //computer_id = dr.Field<int>("comp_id"),

                        maintenance = MaintenanceHelper.GetMaintenance(dr.Field<int>("maintenance_id"))
                        // equipmentHistory = 



                    };
                    
                }
            }

            return assignment;

        }

    }
}
