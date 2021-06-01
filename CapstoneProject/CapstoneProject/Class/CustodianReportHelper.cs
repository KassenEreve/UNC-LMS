using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
    public class CustodianReportHelper
    {
        internal static List<CustodianReport> GetAllUnAssignedCustodianReports() //unassigned reports
        {
            List<CustodianReport> list = null;

            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return null;
                
                var table = dal.ExecuteQuery("GetAllUnAssignedEmergencyReport").Tables[0];

                list = new List<CustodianReport>();

                foreach (DataRow dr in table.AsEnumerable())
                {


                    var save = new CustodianReport()
                    {
                        id = dr.Field<int>("id"),
                        custodian = CustodianHelper.GetCustodian(dr.Field<int>("custodian_id")),
                        custodianReportedItems = CustodianReportedItemHelper.GetReportedItems(dr.Field<int>("id")),
                        date = dr.Field<DateTime>("date"),
                        laboratory = new Laboratory() { id =  dr.Field<int>("lab_id"),roomNum = dr.Field<string>("room_num"), }
                        



                    };
                    list.Add(save);
                }
            }

            return (list.Count() > 0) ? list : null;
        }

        internal static List<CustodianReport> GetAllCustodianReport(Custodian custodian)
        {
            List<CustodianReport> list = null;

            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return null;
                SqlParameter[] param = { new  SqlParameter("@custodian_id",custodian.id)
                                   



                                       };
                var table = dal.ExecuteQuery("GetAllCustodianReport",param).Tables[0];

                list = new List<CustodianReport>();

                foreach (DataRow dr in table.AsEnumerable())
                {


                    var save = new CustodianReport()
                    {
                        id = dr.Field<int>("id"),
                        custodian = CustodianHelper.GetCustodian(dr.Field<int>("custodian_id")),
                        custodianReportedItems = CustodianReportedItemHelper.GetReportedItems(dr.Field<int>("id")),
                        date = dr.Field<DateTime>("date"),
                        laboratory = new Laboratory() { id = dr.Field<int>("lab_id"), roomNum = dr.Field<string>("room_num"), },
                        maintenanceAssignment =  (dr.IsNull("assignmentID")) ? null :EmergenceMaintenanceAssignmentHelper.GetEmergencyMaintenanceAssignment(  dr.Field<int>("assignmentID"))
                        




                    };
                    list.Add(save);
                }
            }

            return (list.Count() > 0) ? list : null;
        }

        /*
        internal static Laboratory GetLaboratory(CustodianReport custodianReport)
        {
            Laboratory lab = null;

            //find the laboratory inside the software inventory
            var software = custodianReport.custodianReportedItems.Find(o => o.softwareInventory != null);
            if(software!=null)
            lab = SoftwareInventoryHelper.GetLaboaratory(software.id);


            //find the laboratory inside the equipments
            if (lab == null)
                lab = custodianReport.custodianReportedItems.Find(o => o.equipment.laboratory != null).equipment.laboratory;  

            return lab;
        }
        */
    }
}
