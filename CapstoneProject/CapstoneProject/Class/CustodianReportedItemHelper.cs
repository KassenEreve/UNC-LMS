using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
    public class CustodianReportedItemHelper
    {
        internal static List<CustodianReportedItem> GetReportedItems(int report_id)
        {
            List<CustodianReportedItem> list = null;

            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return null;
                SqlParameter[] param = { new SqlParameter("@report_id", report_id) };
                var table = dal.ExecuteQuery("GetAllReportedItems", param).Tables[0];

                list = new List<CustodianReportedItem>();

                foreach (DataRow dr in table.AsEnumerable())
                {

                   
                    var save = new CustodianReportedItem()
                    {
                        id = dr.Field<int>("id"),
                       softwareInventory = (dr.IsNull("softwareInv_id"))?null:SoftwareInventoryHelper.GetSoftwareInventory(dr.Field<int>("softwareInv_id")),
                       equipment = (dr.IsNull("equipment_id")) ? null : EquipmentHelper.GetEquipment(dr.Field<int>("equipment_id")),
                       
                       issueDescription  = dr.Field<string>("issue_desc")
                       


                    };
                    list.Add(save);
                }
            }

            return (list.Count() > 0) ? list : null;
        }
    }
}
