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
                        custodianReport = new CustodianReport() { id = dr.Field<int>("custodianReport_id")},
                        //computer_id = dr.Field<int>("comp_id"),

                        maintenance = MaintenanceHelper.GetMaintenance(dr.Field<int>("maintenance_id"))
                        // equipmentHistory = 



                    };
                    
                }
            }

            return assignment;

        }

        internal static List<EmergenceMaintenanceAssignment> GetAllAssignmentHistory()
        {
            List<EmergenceMaintenanceAssignment> list = null;

            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return null;

                var table = dal.ExecuteQuery("GetMaintenanceHistory").Tables[0];

                list = new List<EmergenceMaintenanceAssignment>();

                foreach (DataRow dr in table.AsEnumerable())
                {

                   
                    var save = new EmergenceMaintenanceAssignment()
                    {
                        id = dr.Field<int>("id"),
                        custodianReport = new CustodianReport() {
                            id =  dr.Field<int>("custodianReport_id"),
                            custodian = CustodianHelper.GetCustodian( dr.Field<int>("custodian_id")),
                            date = dr.Field<DateTime>("date"),
                            custodianReportedItems = CustodianReportedItemHelper.GetReportedItems(dr.Field<int>("custodianReport_id")),
                            laboratory=new Laboratory() { id = dr.Field<int>("lab_id"),roomNum = dr.Field<string>("room_num"), }
                            },
                      maintenance = MaintenanceHelper.GetMaintenance(dr.Field<int>("maintenance_id") )
                      



                    };
                    list.Add(save);
                }
            }

            return (list.Count() > 0) ? list : null;
        }

        public static EmergenceMaintenanceAssignment GetEmergencyMaintenanceAssignmentID(Maintenance maintenance)
        {
            EmergenceMaintenanceAssignment assignment = null;

            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return null;
                SqlParameter[] param = { new SqlParameter("@maintenance_id", maintenance.id) };
                var table = dal.ExecuteQuery("GetEmergencyMaintenanceAssignmentID", param).Tables[0];



                foreach (DataRow dr in table.AsEnumerable())
                {


                    assignment = new EmergenceMaintenanceAssignment()
                    {
                        id = dr.Field<int>("id"),
                        custodianReport = new CustodianReport() { id = dr.Field<int>("custodianReport_id") },
                        //computer_id = dr.Field<int>("comp_id"),

                        maintenance =maintenance
                        // equipmentHistory = 



                    };

                }
            }

            return assignment;

        }

        internal static bool SaveMaintenanceAssignment(EmergenceMaintenanceAssignment assignment)
        {
            if (assignment == null)
                return false;

            using (DAL dal = new DAL())
            {

                if (!dal.IsConnected) return false;


                SqlParameter[] param = { new  SqlParameter("@report_id",assignment.custodianReport.id),
                                       new  SqlParameter("@maintenance_id",assignment.maintenance.id)
                                   




                                       };

                try
                {

                    dal.ExecuteNonQuery("SaveMaintenanceAssignment", param);




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
